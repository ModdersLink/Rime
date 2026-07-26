#!/usr/bin/env python3
"""Deep payload probe: array prefix/order/empty semantics + instance order, vanilla vs generated."""
import struct, sys, json
sys.path.insert(0, r'C:\Users\keku\AppData\Local\Temp\claude\C--Users-keku\c0de2aae-1031-4ae4-8d0d-3f554f03c887\scratchpad')
from ebxdiff import Ebx

FT_SIZES = {7:4, 10:1, 11:1, 12:1, 13:2, 14:2, 15:4, 16:4, 17:8, 18:8, 19:4, 20:8, 21:16, 8:4, 3:4, 4:4, 2:None}

def elem_size(e, arr_tidx):
    t = e.types[arr_tidx]
    mem = e.fields[t['layout']]
    ft = (mem['flags'] >> 4) & 0x1F
    if ft == 2:  # ValueType
        return e.types[mem['ftype']]['size'], 'struct:' + e.types[mem['ftype']]['name']
    return FT_SIZES.get(ft, 4), 'ft%d' % ft

def walk_instances(e, tag):
    """walk instance payload; yield (guid, [array field u32 indices in traversal order])"""
    d = e.d
    p = e.instPayloadAt
    order = []       # (typeName, guid)
    arr_refs = []    # u32 array indices in field-traversal order

    def fields_of(tidx):
        """expanded fields incl bases, in layout order (base $ first, recursive)"""
        t = e.types[tidx]
        out = []
        for i in range(t['layout'], t['layout'] + t['fcount']):
            f = e.fields[i]
            ft = (f['flags'] >> 4) & 0x1F
            if ft == 0:  # void = $
                out.extend(fields_of(f['ftype']))
            else:
                out.append(f)
        return out

    def scan_struct(base, tidx):
        for f in fields_of(tidx):
            ft = (f['flags'] >> 4) & 0x1F
            if ft == 4:  # Array
                (idx,) = struct.unpack_from('<I', d, base + f['off'])
                arr_refs.append(idx)
            elif ft == 2:  # nested struct
                scan_struct(base + f['off'], f['ftype'])

    for ie in e.instances:
        t = e.types[ie['tidx']]
        for _ in range(ie['export']):
            guid = d[p:p+16].hex(); p += 16
            order.append((t['name'], guid))
            scan_struct(p, ie['tidx'])
            p += t['size']
    return order, arr_refs

for path, tag in [(sys.argv[1], 'VANILLA'), (sys.argv[2], 'GENERATED')]:
    e = Ebx(open(path, 'rb').read())
    print('===== %s =====' % tag)

    # --- array entry order & gaps ---
    arrs = e.arrays
    nonempty = [a for a in arrs if a['count'] > 0]
    empty = [a for a in arrs if a['count'] == 0]
    print('arrays: %d (%d empty)' % (len(arrs), len(empty)))
    if empty:
        ee = empty[0]
        print(' first empty entry: idx=%d off=%d tidx=%d(%s)' % (arrs.index(ee), ee['off'], ee['tidx'], e.tname(ee['tidx'])))
    # offsets monotonic in entry order?
    mono = all(arrs[i]['off'] <= arrs[i+1]['off'] for i in range(len(arrs)-1))
    print(' offsets monotonic non-decreasing in entry order: %s' % mono)
    # gap analysis on entries sorted by offset (non-empty)
    se = sorted(nonempty, key=lambda a: a['off'])
    gaps = {}
    bad = 0
    for i in range(len(se) - 1):
        sz, _ = elem_size(e, se[i]['tidx'])
        expect = se[i]['count'] * sz
        gap = se[i+1]['off'] - se[i]['off'] - expect
        gaps[gap] = gaps.get(gap, 0) + 1
    print(' gap histogram (nextOff - off - count*elemSize): %s' % dict(sorted(gaps.items())[:8]))
    print(' first 6 entries (order as stored): %s' % [(a['off'], a['count'], e.tname(a['tidx'])) for a in arrs[:6]])
    lo = min(a['off'] for a in arrs)
    print(' min offset=%d; bytes at arrayPayload start (32B): %s' % (lo, e.d[e.arrPayloadAt:e.arrPayloadAt+32].hex()))

    # --- instance traversal vs array indices ---
    order, arr_refs = walk_instances(e, tag)
    print(' instances walked: %d, array-field refs: %d' % (len(order), len(arr_refs)))
    seq_ok = all(arr_refs[i] == i for i in range(len(arr_refs)))
    print(' array indices == 0,1,2,... in traversal order: %s' % seq_ok)
    if not seq_ok:
        # show pattern of first 20 and how empties map
        print(' first 24 refs: %s' % arr_refs[:24])
        idx_empty = set(i for i, a in enumerate(arrs) if a['count'] == 0)
        nonseq = [(i, r) for i, r in enumerate(arr_refs) if r != i][:10]
        print(' first mismatches (pos, ref): %s' % nonseq)
        emp_refs = set(r for r in arr_refs if r in idx_empty)
        print(' distinct EMPTY entries referenced: %d' % len(emp_refs))
    print(' first 5 instances: %s' % order[:5])
    print(' last 2 instances: %s' % order[-2:])

# JSON dump order comparison
try:
    j = json.load(open('F:/tmp/subwaygrid.json'))
    jg = list(j['Instances'].keys())
    print('\nJSON dump: %d instances; first 5 guids: %s' % (len(jg), jg[:5]))
except Exception as ex:
    print('json skip:', ex)

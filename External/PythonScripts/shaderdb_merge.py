#!/usr/bin/env python
"""
BF3 IShaderDatabase (version 182) MERGER.
Appends a foreign level shaderdb's shaders into a target level shaderdb so the
foreign shader's compiled permutation resolves from the single (augmented) db.

Layout (per RimeLib.Shader.Frostbite2_0):
 ShaderDatabaseContainer: u32 renderPathCount; for each: u32 path, u32 dbSize, db[dbSize]
 ShaderDatabase: u32 version(==182), u32 renderPath,
   u32 nConst;   each Const  = u32 size (size INCLUDES this field) -> total `size` bytes
   u32 nCF;      each CF      = u16 cnt, u16 reg, cnt*8 (u32 func + 4 bytes)
   u32 nTF;      each TF      = u32 cnt, cnt*4
   u32 nVP;      each VP      = GUID16 + u32 dsz + bc[dsz] + u32 cIdx + u32 cfIdx + u32 tfIdx
                               + i32 ssz + sig[ssz] + u32 nEl + nEl*24 + u32 nNames + names(nullterm) + u32 instr
   u32 nPP;      each PP      = GUID16 + u32 dsz + bc[dsz] + u32 cIdx + u32 cfIdx + u32 tfIdx + u32 instr
   u32 nGP;      each GP      = GUID16 + u32 dsz + bc[dsz] + u32 instr
   u32 nSol;     each Sol     = 64 bytes: u64 stateHash + u8 flags + u8 surf + u8 blend + 13 pad
                               + i64 vpIdx + i64 ppIdx + i64 gpIdx + i64 vcIdx + i64 pcIdx
   u32 nState;   each State   = 32 bytes (fixed; no cross-section idx)
   u32 nDecl;    each Decl    = u32 hash + 76 bytes desc
   u32 nShader;  each Shader  = u32 keyHash + SurfaceShaderInfo
     SurfaceShaderInfo = u32 surfType + u8 flags + u8 boolCnt + u8 defMask + u8 reqMask + 8*u32 boolIds(32)
        + u32 nST + nST*[nullstr + u32 + u32 + f32]
        + u32 nSET + nSET*[nullstr + u32 + u32 + u32 + f32]
        + u32 nSolRef + nSolRef*u16   (<- solution indices)
"""
import struct, sys

class R:
    def __init__(s, d, o=0): s.d=d; s.o=o
    def u8(s):  v=s.d[s.o]; s.o+=1; return v
    def u16(s): v=struct.unpack_from('<H',s.d,s.o)[0]; s.o+=2; return v
    def u32(s): v=struct.unpack_from('<I',s.d,s.o)[0]; s.o+=4; return v
    def i32(s): v=struct.unpack_from('<i',s.d,s.o)[0]; s.o+=4; return v
    def skip(s,n): s.o+=n
    def nullstr(s):
        e=s.d.index(0, s.o); s.o=e+1
        return e+1

def parse_db(d, base, size):
    """Parse one ShaderDatabase. Returns dict of sections; each section = list of (start,end) byte ranges
       within d, plus recorded index-field absolute positions for VP/PP/Sol/Shader."""
    r=R(d, base)
    ver=r.u32(); assert ver==182, f"version {ver}"
    rp=r.u32()
    out={'ver_rp_start':base, 'header_end':r.o, 'renderpath':rp}
    # Constants
    n=r.u32(); consts=[]
    for _ in range(n):
        st=r.o; sz=r.u32(); r.skip(sz-4); consts.append((st,r.o))
    out['const']=consts
    # ConstFunctions
    n=r.u32(); cf=[]
    for _ in range(n):
        st=r.o; cnt=r.u16(); r.u16(); r.skip(cnt*8); cf.append((st,r.o))
    out['cf']=cf
    # TexFunctions
    n=r.u32(); tf=[]
    for _ in range(n):
        st=r.o; cnt=r.u32(); r.skip(cnt*4); tf.append((st,r.o))
    out['tf']=tf
    # VertexPerms (record 3 index positions)
    n=r.u32(); vp=[]; vp_idx=[]
    for _ in range(n):
        st=r.o
        r.skip(16); dsz=r.u32(); r.skip(dsz)
        pidx=r.o            # cIdx,cfIdx,tfIdx here
        r.skip(12)
        ssz=r.i32(); r.skip(ssz)
        nel=r.u32(); r.skip(nel*24)
        nnm=r.u32()
        for _ in range(nnm): r.nullstr()
        r.u32() # instr
        vp.append((st,r.o)); vp_idx.append(pidx)
    out['vp']=vp; out['vp_idx']=vp_idx
    # PixelPerms
    n=r.u32(); pp=[]; pp_idx=[]
    for _ in range(n):
        st=r.o
        r.skip(16); dsz=r.u32(); r.skip(dsz)
        pidx=r.o
        r.skip(12); r.u32()  # 3 idx + instr
        pp.append((st,r.o)); pp_idx.append(pidx)
    out['pp']=pp; out['pp_idx']=pp_idx
    # GeomPerms
    n=r.u32(); gp=[]
    for _ in range(n):
        st=r.o; r.skip(16); dsz=r.u32(); r.skip(dsz); r.u32()
        gp.append((st,r.o))
    out['gp']=gp
    # Solutions (fixed 64B; 5 i64 idx at offset 24)
    n=r.u32(); sol=[]; sol_idx=[]
    for _ in range(n):
        st=r.o; r.skip(64); sol.append((st,r.o)); sol_idx.append(st+24)
    out['sol']=sol; out['sol_idx']=sol_idx
    # SolutionStates (fixed 32B)
    n=r.u32(); state=[]
    for _ in range(n):
        st=r.o; r.skip(32); state.append((st,r.o))
    out['state']=state
    # Declarations (80B: u32 hash + 76 desc)
    n=r.u32(); decl=[]
    for _ in range(n):
        st=r.o; r.skip(80); decl.append((st,r.o))
    out['decl']=decl
    # Shaders
    n=r.u32(); sh=[]; sh_solpos=[]   # for each shader: list of u16 solution-index abs positions
    for _ in range(n):
        st=r.o
        r.u32() # keyHash
        r.u32() # surfType
        r.skip(4)        # flags,boolCnt,defMask,reqMask
        r.skip(32)       # 8*u32 boolIds
        nst=r.u32()
        for _ in range(nst):
            r.nullstr(); r.skip(12)   # u32+u32+f32
        nset=r.u32()
        for _ in range(nset):
            r.nullstr(); r.skip(16)   # u32+u32+u32+f32
        nsr=r.u32()
        positions=[r.o + k*2 for k in range(nsr)]
        r.skip(nsr*2)
        sh.append((st,r.o)); sh_solpos.append(positions)
    out['sh']=sh; out['sh_solpos']=sh_solpos
    out['db_end']=r.o
    assert r.o==base+size, f"db parse end {r.o} != {base+size}"
    return out

def parse_container(d):
    r=R(d,0); npaths=r.u32(); paths=[]
    for _ in range(npaths):
        path=r.u32(); dbsz=r.u32(); start=r.o
        db=parse_db(d, start, dbsz)
        db['path_id']=path; db['db_size']=dbsz
        paths.append(db)
        r.o=start+dbsz
    assert r.o==len(d), f"container end {r.o} != {len(d)}"
    return paths

def fletcher32(data):
    c0=c1=0; n=len(data)//2; pos=0
    L=n
    while L>0:
        blk=min(L,360); L-=blk
        for _ in range(blk):
            w=(data[pos]<<8)|data[pos+1]; pos+=2   # big-endian u16
            c0=(c0+w)&0xFFFFFFFF; c1=(c1+c0)&0xFFFFFFFF
        c0=(c0&0xFFFF)+(c0>>16); c1=(c1&0xFFFF)+(c1>>16)
    if len(data)%2!=0:
        c0=(c0+data[pos])&0xFFFFFFFF; c1=(c1+c1)&0xFFFFFFFF
    c0=(c0&0xFFFF)+(c0>>16); c1=(c1&0xFFFF)+(c1>>16)
    return ((c0<<16)|c1)&0xFFFFFFFF

def fletcher64(data):
    h=len(data)//2
    p1=fletcher32(data[:h]); p2=fletcher32(data[h:])
    return ((p2<<32)|p1)&0xFFFFFFFFFFFFFFFF

def hashquick(s):
    h=0x1505
    for ch in s:
        h=((h*0x21) ^ ord(ch)) & 0xFFFFFFFF
    return h

def slc(d, rng): return d[rng[0]:rng[1]]

def build_section(d18, ranges, idxpos_list, patch_fn):
    """Return concatenated patched bytes for MP_018 elements."""
    out=bytearray()
    for (rng, ip) in zip(ranges, idxpos_list):
        b=bytearray(slc(d18,rng))
        patch_fn(b, rng[0], ip)
        out+=b
    return bytes(out)

def patch_const_block_textures(buf, remap):
    """buf = one ShaderConstant block (starts with u32 size). Patch TextureConstant.Name per remap."""
    if len(buf) < 54: return
    tco=struct.unpack_from('<Q',buf,16)[0]
    tcc=buf[53]
    p=tco
    for _ in range(tcc):
        nm=bytes(buf[p+8:p+8+128]).split(b'\x00')[0].decode('latin1')
        if nm in remap:
            new=remap[nm].encode('latin1')
            buf[p+8:p+8+128]=new + b'\x00'*(128-len(new))
        p+=152

def merge_multi(d17, d18, out_path, subs, remap=None):
    """subs = list of (target_exact_name_MP17, source_exact_name_MP18).
       Appends MP_018 perms/constants ONCE (shared); per sub appends FRESH copies of the source
       shader's referenced solutions (renamed to target, re-indexed) and substitutes the target's
       SurfaceShaderInfo. No foreign shader entries, no shared dead-weight solutions."""
    P17=parse_container(d17); P18=parse_container(d18); m18={p['path_id']:p for p in P18}
    out=bytearray(); merged=[]
    for a in P17:
        b=m18.get(a['path_id'])
        if b is None: merged.append((a['path_id'], slc(d17,(a['ver_rp_start'],a['db_end'])))); continue
        merged.append((a['path_id'], merge_db_multi(d17,a,d18,b,subs,remap)))
    cont=bytearray(); cont+=struct.pack('<I',len(merged))
    for path,db in merged: cont+=struct.pack('<II',path,len(db))+db
    open(out_path,'wb').write(cont); return len(cont),len(merged)

def merge_db_multi(d17,a,d18,b,subs,remap=None):
    C17=len(a['const']);CF17=len(a['cf']);TF17=len(a['tf']);VP17=len(a['vp']);PP17=len(a['pp']);GP17=len(a['gp']);S17=len(a['sol'])
    db=bytearray(); db+=struct.pack('<II',182,a['path_id'])
    def emit(n,blob):
        nonlocal db; db+=struct.pack('<I',n); db+=blob
    def cat(d,ranges):
        o=bytearray()
        for r in ranges: o+=d[r[0]:r[1]]
        return bytes(o)
    def patch_perm(buf):  # buf=one perm; idx at GUID16+u32dsz+bc -> need to locate
        pass
    # --- shared sections (const/cf/tf/vp/pp/gp) : MP_017 + MP_018 (re-indexed) ---
    # const (optional remap)
    c18=bytearray()
    for rng in b['const']:
        cb=bytearray(slc(d18,rng))
        if remap: patch_const_block_textures(cb,remap)
        c18+=cb
    emit(C17+len(b['const']), cat(d17,a['const'])+bytes(c18))
    emit(CF17+len(b['cf']), cat(d17,a['cf'])+cat(d18,b['cf']))
    emit(TF17+len(b['tf']), cat(d17,a['tf'])+cat(d18,b['tf']))
    def perm18(ranges, idxs):
        o=bytearray()
        for rng,ip in zip(ranges,idxs):
            buf=bytearray(slc(d18,rng)); loc=ip-rng[0]
            for k,off in enumerate((C17,CF17,TF17)):
                struct.pack_into('<I',buf,loc+k*4, struct.unpack_from('<I',buf,loc+k*4)[0]+off)
            o+=buf
        return bytes(o)
    emit(VP17+len(b['vp']), cat(d17,a['vp'])+perm18(b['vp'],b['vp_idx']))
    emit(PP17+len(b['pp']), cat(d17,a['pp'])+perm18(b['pp'],b['pp_idx']))
    emit(GP17+len(b['gp']), cat(d17,a['gp'])+cat(d18,b['gp']))
    # --- solutions/states: MP_017 verbatim, then per-sub fresh copies of source's solutions ---
    sol_extra=bytearray(); state_extra=bytearray()
    next_idx=S17
    sub_solmap=[]   # per sub: dict MP18-localSolIdx -> new merged idx
    for (tgt_exact, src_exact) in subs:
        skey=hashquick(src_exact.lower()); tkey=hashquick(tgt_exact.lower())
        # find source shader's solution indices
        srcsol=None
        for rng,positions in zip(b['sh'],b['sh_solpos']):
            if struct.unpack_from('<I',d18,rng[0])[0]==skey:
                srcsol=[struct.unpack_from('<H',d18,p)[0] for p in positions]; break
        assert srcsol is not None, f"source {src_exact} not found"
        mp={}
        for si in srcsol:
            if si in mp: continue
            solrng=b['sol'][si]; strng=b['state'][si]
            sbuf=bytearray(slc(d18,solrng))
            loc=24
            offs=(VP17,PP17,GP17,C17,C17)
            for k,off in enumerate(offs):
                v=struct.unpack_from('<q',sbuf,loc+k*8)[0]
                if v!=-1: struct.pack_into('<q',sbuf,loc+k*8,v+off)
            stbuf=bytearray(slc(d18,strng))
            if struct.unpack_from('<I',stbuf,0)[0]==skey:
                struct.pack_into('<I',stbuf,0,tkey)
            struct.pack_into('<Q',sbuf,0, fletcher64(bytes(stbuf)))
            mp[si]=next_idx; next_idx+=1
            sol_extra+=sbuf; state_extra+=stbuf
        sub_solmap.append(mp)
    emit(S17+ (next_idx-S17), cat(d17,a['sol'])+bytes(sol_extra))
    emit(S17+ (next_idx-S17), cat(d17,a['state'])+bytes(state_extra))
    # declarations
    emit(len(a['decl'])+len(b['decl']), cat(d17,a['decl'])+cat(d18,b['decl']))
    # shaders: MP_017's, substitute each target's SurfaceShaderInfo with source's (re-pointed sol refs)
    tgt_keys={hashquick(t.lower()):i for i,(t,s) in enumerate(subs)}
    # precompute each source's SurfaceShaderInfo bytes + its sol-ref positions
    src_info={}
    for i,(t,s) in enumerate(subs):
        skey=hashquick(s.lower())
        for rng,positions in zip(b['sh'],b['sh_solpos']):
            if struct.unpack_from('<I',d18,rng[0])[0]==skey:
                src_info[i]=(rng,positions); break
    sh=bytearray(); subbed=0
    for rng in a['sh']:
        keyhash=struct.unpack_from('<I',d17,rng[0])[0]
        if keyhash in tgt_keys:
            si=tgt_keys[keyhash]; srng,spos=src_info[si]; mp=sub_solmap[si]
            buf=bytearray(slc(d18,srng))
            for p in spos:
                loc=p-srng[0]; old=struct.unpack_from('<H',buf,loc)[0]
                struct.pack_into('<H',buf,loc, mp[old])
            sh+=struct.pack('<I',keyhash)+bytes(buf[4:]); subbed+=1
        else:
            sh+=slc(d17,rng)
    import sys as _s; _s.stderr.write(f"[multisub] path 0x{a['path_id']:X}: substituted {subbed}/{len(subs)} shaders, +{next_idx-S17} solutions\n")
    emit(len(a['sh']), bytes(sh))
    return bytes(db)


def retex(d, out_path, remap):
    """Remap TextureConstant.Name across ALL constant blocks of ALL render paths (in place, same
    byte size). Used to repoint a shader's reference to a texture that can't be packaged (e.g. a
    DLC texture with no CAS variant) onto one that IS present, so the shader never samples a
    missing texture (which would null-SRV crash the GPU)."""
    d = bytearray(d)
    P = parse_container(bytes(d))
    n = 0
    for a in P:
        for st, en in a['const']:
            blk = bytearray(d[st:en]); before = bytes(blk)
            patch_const_block_textures(blk, remap)
            if bytes(blk) != before:
                d[st:en] = blk; n += 1
    open(out_path, 'wb').write(d)
    import sys as _s; _s.stderr.write(f"[retex] remapped textures in {n} constant block(s)\n")
    return n


def pad(d, out_path, target_bytes):
    """SIZE TEST: bloat the shaderdb to `target_bytes` by appending DUPLICATE constant blocks
    to render-path 0 (dead weight — no solution/shader references them, NO new shader entry).
    Used to tell apart a size-driven client hang from an added-entry hang."""
    P = parse_container(d)
    a = P[0]
    base = a['ver_rp_start']
    if not a['const']:
        open(out_path, 'wb').write(d); return len(d)
    blk = slc(d, a['const'][0])           # first constant block (valid, self-sized)
    need = max(0, target_bytes - len(d))
    K = (need // len(blk)) + 1 if need > 0 else 0
    c_start = a['const'][0][0]; c_end = a['const'][-1][1]
    new_db = bytearray()
    new_db += d[base:base + 8]                                  # ver + renderpath
    new_db += struct.pack('<I', len(a['const']) + K)           # bumped constant count
    new_db += d[c_start:c_end]                                 # original constant blocks
    new_db += blk * K                                          # padding copies
    new_db += d[c_end:a['db_end']]                             # cf/tf/vp/pp/.../sh verbatim
    out = bytearray(); out += struct.pack('<I', len(P))
    for p in P:
        if p is a:
            out += struct.pack('<II', p['path_id'], len(new_db)) + bytes(new_db)
        else:
            out += struct.pack('<II', p['path_id'], p['db_size']) + d[p['ver_rp_start']:p['db_end']]
    open(out_path, 'wb').write(out)
    import sys as _s; _s.stderr.write(f"[pad] +{K} dead const blocks ({len(blk)}B ea) -> {len(out)} bytes\n")
    return len(out)


def merge_append(d17, d18, out_path, src_exact, remap=None, swap=False):
    """APPEND one foreign shader (by its real name/keyHash) into the target db so a block can
    reference the foreign name directly. Like the multisub path it appends the shared perm/const
    sections but ONLY the REFERENCED solutions (appending ALL foreign solutions hangs the client),
    then appends the foreign SHADER entry (keeping its own keyHash) re-pointed to those solutions."""
    P17 = parse_container(d17); P18 = parse_container(d18)
    m18 = {p['path_id']: p for p in P18}
    skey = hashquick(src_exact.lower())
    merged = []; napp = 0
    for a in P17:
        b = m18.get(a['path_id'])
        has = b is not None and any(struct.unpack_from('<I', d18, rng[0])[0] == skey for rng in b['sh'])
        if not has:
            merged.append((a['path_id'], slc(d17, (a['ver_rp_start'], a['db_end'])))); continue
        merged.append((a['path_id'], merge_db_append(d17, a, d18, b, src_exact, remap, swap))); napp += 1
    cont = bytearray(); cont += struct.pack('<I', len(merged))
    for path, db in merged:
        cont += struct.pack('<II', path, len(db)) + db
    open(out_path, 'wb').write(cont)
    import sys as _s; _s.stderr.write(f"[append] {src_exact}: appended into {napp} render-path(s)\n")
    return len(cont), len(merged)


def merge_db_append(d17, a, d18, b, src_exact, remap=None, swap=False):
    """Append the foreign shader by its real name/keyHash, SMALL & CORRECT. The big bytes are the
    PERMS (vp/pp, ~2KB each, thousands); const/cf/tf/decl are tiny. So keep ALL foreign const/cf/
    tf/decl (avoids their internal index refs entirely) but SLICE the perms to only the ones this
    shader's solutions use (perms reference only cIdx/cfIdx/tfIdx, confirmed — the trailing block
    is the vertex input layout). Only the referenced solutions are kept too. ~+0.5MB per shader
    vs ~+28MB for the full append, so the db stays small enough to load."""
    import os as _os
    NONE = 0xFFFFFFFF
    C17=len(a['const']);CF17=len(a['cf']);TF17=len(a['tf']);VP17=len(a['vp']);PP17=len(a['pp']);GP17=len(a['gp']);S17=len(a['sol'])
    skey = hashquick(src_exact.lower())
    srcsol = None
    for rng, positions in zip(b['sh'], b['sh_solpos']):
        if struct.unpack_from('<I', d18, rng[0])[0] == skey:
            srcsol = []
            for p in positions:
                v = struct.unpack_from('<H', d18, p)[0]
                if v not in srcsol: srcsol.append(v)
            sh_rng, sh_pos = rng, positions; break
    assert srcsol is not None, f"source {src_exact} not found in path 0x{a['path_id']:X}"
    # walk solutions -> referenced perms (the big sections to slice)
    need_vp=set(); need_pp=set(); need_gp=set()
    for si in srcsol:
        sr=b['sol'][si][0]; vp,pp,gp,vc,pc=struct.unpack_from('<5q',d18,sr+24)
        if vp!=-1: need_vp.add(vp)
        if pp!=-1: need_pp.add(pp)
        if gp!=-1: need_gp.add(gp)
    vp_lst=sorted(need_vp); vp_map={o:i for i,o in enumerate(vp_lst)}
    pp_lst=sorted(need_pp); pp_map={o:i for i,o in enumerate(pp_lst)}
    gp_lst=sorted(need_gp); gp_map={o:i for i,o in enumerate(gp_lst)}
    db = bytearray(); db += struct.pack('<II', 182, a['path_id'])
    def emit(n, blob):
        nonlocal db; db += struct.pack('<I', n); db += blob
    def cat(d, ranges):
        o = bytearray()
        for r in ranges: o += d[r[0]:r[1]]
        return bytes(o)
    # const/cf/tf: target + ALL foreign (kept whole so their internal refs stay valid)
    c18 = bytearray()
    for rng in b['const']:
        cb = bytearray(slc(d18, rng))
        if remap: patch_const_block_textures(cb, remap)
        c18 += cb
    emit(C17 + len(b['const']), cat(d17, a['const']) + bytes(c18))
    emit(CF17 + len(b['cf']), cat(d17, a['cf']) + cat(d18, b['cf']))
    emit(TF17 + len(b['tf']), cat(d17, a['tf']) + cat(d18, b['tf']))
    # perms: target + only the REFERENCED foreign perms, re-index their cIdx/cfIdx/tfIdx by the
    # const/cf/tf offsets (all foreign const/cf/tf kept, so +C17/+CF17/+TF17 is correct).
    def perm_sliced(lst, ranges, idxs):
        o=bytearray()
        for old in lst:
            rng=ranges[old]; buf=bytearray(slc(d18,rng)); loc=idxs[old]-rng[0]
            for k,off in ((0,C17),(4,CF17),(8,TF17)):
                v=struct.unpack_from('<I',buf,loc+k)[0]
                if v!=NONE: struct.pack_into('<I',buf,loc+k, v+off)
            o+=buf
        return bytes(o)
    emit(VP17+len(vp_lst), cat(d17,a['vp'])+perm_sliced(vp_lst,b['vp'],b['vp_idx']))
    emit(PP17+len(pp_lst), cat(d17,a['pp'])+perm_sliced(pp_lst,b['pp'],b['pp_idx']))
    emit(GP17+len(gp_lst), cat(d17,a['gp'])+cat(d18,[b['gp'][o] for o in gp_lst]))
    # solutions: only referenced; re-index vp/pp/gp to the sliced positions, vc/pc by +C17
    sol_extra=bytearray(); state_extra=bytearray(); mp={}; nxt=S17
    for si in srcsol:
        if si in mp: continue
        sbuf=bytearray(slc(d18,b['sol'][si])); loc=24
        refs=list(struct.unpack_from('<5q',sbuf,loc))
        newmap=[(vp_map,VP17),(pp_map,PP17),(gp_map,GP17),(None,C17),(None,C17)]
        for k,(mk,base) in enumerate(newmap):
            v=refs[k]
            if v!=-1:
                struct.pack_into('<q',sbuf,loc+k*8, base+(mk[v] if mk is not None else v))
        mp[si]=nxt; nxt+=1
        sol_extra+=sbuf; state_extra+=slc(d18,b['state'][si])
    emit(S17+len(mp), cat(d17,a['sol'])+bytes(sol_extra))
    emit(S17+len(mp), cat(d17,a['state'])+bytes(state_extra))
    emit(len(a['decl'])+len(b['decl']), cat(d17,a['decl'])+cat(d18,b['decl']))
    # shaders: target's + the foreign entry (own keyHash) re-pointed to the appended sols.
    if _os.environ.get("TT_APPEND_NO_ENTRY"):
        emit(len(a['sh']), cat(d17, a['sh']))
        import sys as _s; _s.stderr.write(f"[append] path 0x{a['path_id']:X}: NO entry [size-control], +{len(vp_lst)}vp +{len(pp_lst)}pp\n")
        return bytes(db)
    buf=bytearray(slc(d18,sh_rng))
    for p in sh_pos:
        loc=p-sh_rng[0]; old=struct.unpack_from('<H',buf,loc)[0]
        struct.pack_into('<H',buf,loc, mp[old])
    if swap:
        # swapentry: REPLACE the dst's own entry for this keyHash with the src's (re-pointed) one —
        # append semantics (in-game proven for new entries) applied to an existing key.
        keep=bytearray(); dropped=0
        for rng2 in a['sh']:
            if not dropped and struct.unpack_from('<I', d17, rng2[0])[0]==skey:
                dropped=1; continue
            keep+=slc(d17,rng2)
        emit(len(a['sh'])-dropped+1, bytes(keep)+bytes(buf))
        import sys as _s; _s.stderr.write(f"[swapentry] path 0x{a['path_id']:X}: entry replaced (dropped {dropped} dst entry), +{len(mp)}sol +{len(vp_lst)}vp +{len(pp_lst)}pp\n")
        return bytes(db)
    emit(len(a['sh'])+1, cat(d17,a['sh'])+bytes(buf))
    import sys as _s; _s.stderr.write(f"[append] path 0x{a['path_id']:X}: +1 shader, +{len(mp)}sol +{len(vp_lst)}vp +{len(pp_lst)}pp (sliced perms, full const/cf/tf)\n")
    return bytes(db)

def merge_solutions(d17, d18, out_path, names):
    """mergesol: EXTEND existing dst shader entries with the src entry's solutions whose 32B
    SolutionState is MISSING in dst (union by state). Why: a level compiles only the
    (shader x vertex-declaration x feature-state) solutions ITS content uses — a foreign mesh's
    declaration may have no solution in the dst entry, so the engine falls back and the Camo/Decal
    layers are lost (the grey M1A2 hull on MP_017: 14 tank states of vehiclepreset_mud exist in
    XP1_002/MP_007 but not MP_017; state bytes 8-11 = vertex declaration hash). Slices ONLY the
    missing solutions + their vp/pp/gp perms (re-indexed), appends full const/cf/tf/decl (same
    proven tradeoff as merge_db_append), and REWRITES the dst entry's trailing u16 solution-index
    list in place (entries are variable length; the section is rebuilt sequentially).
    Does NOT write the out file when nothing was missing (returns (0,0))."""
    P17 = parse_container(d17); P18 = parse_container(d18)
    m18 = {p['path_id']: p for p in P18}
    merged = []; total = 0
    for a in P17:
        b = m18.get(a['path_id'])
        if b is None:
            merged.append((a['path_id'], slc(d17, (a['ver_rp_start'], a['db_end'])))); continue
        db, n = merge_solutions_db(d17, a, d18, b, names)
        total += n
        merged.append((a['path_id'], db))
    if total == 0:
        return 0, 0
    cont = bytearray(); cont += struct.pack('<I', len(merged))
    for path, db in merged:
        cont += struct.pack('<II', path, len(db)) + db
    open(out_path, 'wb').write(cont)
    import sys as _s; _s.stderr.write(f"[mergesol] merged {total} solution(s) across {len(merged)} render-path(s)\n")
    return len(cont), total


def merge_solutions_db(d17, a, d18, b, names):
    NONE = 0xFFFFFFFF
    C17=len(a['const']);CF17=len(a['cf']);TF17=len(a['tf']);VP17=len(a['vp']);PP17=len(a['pp']);GP17=len(a['gp']);S17=len(a['sol'])
    def find(dx, P, key):
        for i,(rng, positions) in enumerate(zip(P['sh'], P['sh_solpos'])):
            if struct.unpack_from('<I', dx, rng[0])[0] == key:
                return i, rng, positions
        return None, None, None
    add_per_entry = {}   # dst entry idx -> new solution indices to append to its list
    mp = {}              # src solution idx -> new dst solution idx
    order = []           # src solution indices in append order
    for nm in names:
        key = hashquick(nm.lower())
        di, drng, dpos = find(d17, a, key)
        si_, srng, spos = find(d18, b, key)
        if di is None or si_ is None: continue
        seen = set()
        for p in dpos:
            v = struct.unpack_from('<H', d17, p)[0]
            seen.add(bytes(slc(d17, a['state'][v])))
        missing = []
        for p in spos:
            v = struct.unpack_from('<H', d18, p)[0]
            st = bytes(slc(d18, b['state'][v]))
            if st in seen: continue
            seen.add(st)
            missing.append(v)
        if not missing: continue
        add_per_entry.setdefault(di, [])
        for v in missing:
            if v not in mp:
                mp[v] = S17 + len(order); order.append(v)
            add_per_entry[di].append(mp[v])
        import sys as _s; _s.stderr.write(f"[mergesol] path 0x{a['path_id']:X} {nm}: +{len(missing)} solution(s)\n")
    if not order:
        return slc(d17, (a['ver_rp_start'], a['db_end'])), 0
    # perms the added solutions reference (the big sections -> slice)
    need_vp=set(); need_pp=set(); need_gp=set()
    for si in order:
        sr=b['sol'][si][0]; vp,pp,gp,vc,pc=struct.unpack_from('<5q',d18,sr+24)
        if vp!=-1: need_vp.add(vp)
        if pp!=-1: need_pp.add(pp)
        if gp!=-1: need_gp.add(gp)
    vp_lst=sorted(need_vp); vp_map={o:i for i,o in enumerate(vp_lst)}
    pp_lst=sorted(need_pp); pp_map={o:i for i,o in enumerate(pp_lst)}
    gp_lst=sorted(need_gp); gp_map={o:i for i,o in enumerate(gp_lst)}
    db=bytearray(); db+=struct.pack('<II',182,a['path_id'])
    def emit(n, blob):
        nonlocal db; db+=struct.pack('<I',n); db+=blob
    def cat(dx, ranges):
        o=bytearray()
        for r in ranges: o+=dx[r[0]:r[1]]
        return bytes(o)
    # const/cf/tf: dst + ALL src (kept whole so their internal refs stay valid — proven tradeoff)
    emit(C17+len(b['const']), cat(d17,a['const'])+cat(d18,b['const']))
    emit(CF17+len(b['cf']), cat(d17,a['cf'])+cat(d18,b['cf']))
    emit(TF17+len(b['tf']), cat(d17,a['tf'])+cat(d18,b['tf']))
    def perm_sliced(lst, ranges, idxs):
        o=bytearray()
        for old in lst:
            rng=ranges[old]; buf=bytearray(slc(d18,rng)); loc=idxs[old]-rng[0]
            for k,off in ((0,C17),(4,CF17),(8,TF17)):
                v=struct.unpack_from('<I',buf,loc+k)[0]
                if v!=NONE: struct.pack_into('<I',buf,loc+k, v+off)
            o+=buf
        return bytes(o)
    emit(VP17+len(vp_lst), cat(d17,a['vp'])+perm_sliced(vp_lst,b['vp'],b['vp_idx']))
    emit(PP17+len(pp_lst), cat(d17,a['pp'])+perm_sliced(pp_lst,b['pp'],b['pp_idx']))
    emit(GP17+len(gp_lst), cat(d17,a['gp'])+cat(d18,[b['gp'][o] for o in gp_lst]))
    # solutions + states: dst + the sliced missing ones (perm refs re-indexed, vc/pc by +C17)
    sol_extra=bytearray(); state_extra=bytearray()
    for si in order:
        sbuf=bytearray(slc(d18,b['sol'][si])); loc=24
        refs=list(struct.unpack_from('<5q',sbuf,loc))
        for k,(mk,base) in enumerate(((vp_map,VP17),(pp_map,PP17),(gp_map,GP17),(None,C17),(None,C17))):
            v=refs[k]
            if v!=-1: struct.pack_into('<q',sbuf,loc+k*8, base+(mk[v] if mk is not None else v))
        sol_extra+=sbuf; state_extra+=slc(d18,b['state'][si])
    emit(S17+len(order), cat(d17,a['sol'])+bytes(sol_extra))
    emit(S17+len(order), cat(d17,a['state'])+bytes(state_extra))
    emit(len(a['decl'])+len(b['decl']), cat(d17,a['decl'])+cat(d18,b['decl']))
    # shader entries: rebuild the section, extending the merged entries' trailing u16 index list
    sh_blob=bytearray()
    for i,(rng, positions) in enumerate(zip(a['sh'], a['sh_solpos'])):
        buf=bytearray(slc(d17,rng))
        adds=add_per_entry.get(i)
        if adds:
            nsr=len(positions)
            nsr_off=(rng[1]-rng[0]) - nsr*2 - 4   # nsr u32 sits right before the u16 list at the entry end
            struct.pack_into('<I', buf, nsr_off, nsr+len(adds))
            for v in adds: buf+=struct.pack('<H', v)
        sh_blob+=buf
    emit(len(a['sh']), bytes(sh_blob))
    return bytes(db), len(order)


def transplant_solutions(d17, d18, out_path, names):
    """transplant: for each dst entry solution whose state has technique byte[14] in {01,04}, find the
    src solution whose state is IDENTICAL except byte[14]==09 (the camo-composite variant) and OVERWRITE
    the dst solution's perm refs (vp/pp/gp/vc/pc at sol+24) with the src's (perms sliced+appended,
    re-indexed). Dst STATES and stored fletcher hashes stay untouched — the engine's request keeps
    matching exactly what it always matched, but the compiled pixel/vertex shaders now sample Camo/
    Decals. THE probe for 'the technique byte is level-derived and MP_017 never requests 09'."""
    P17 = parse_container(d17); P18 = parse_container(d18)
    m18 = {p['path_id']: p for p in P18}
    merged = []; total = 0
    for a in P17:
        b = m18.get(a['path_id'])
        if b is None:
            merged.append((a['path_id'], slc(d17, (a['ver_rp_start'], a['db_end'])))); continue
        db, n = transplant_db(d17, a, d18, b, names)
        total += n
        merged.append((a['path_id'], db))
    if total == 0:
        return 0, 0
    cont = bytearray(); cont += struct.pack('<I', len(merged))
    for path, db in merged:
        cont += struct.pack('<II', path, len(db)) + db
    open(out_path, 'wb').write(cont)
    import sys as _s; _s.stderr.write(f"[transplant] {total} solution(s) re-pointed across {len(merged)} render-path(s)\n")
    return len(cont), total


def transplant_db(d17, a, d18, b, names):
    NONE = 0xFFFFFFFF
    C17=len(a['const']);CF17=len(a['cf']);TF17=len(a['tf']);VP17=len(a['vp']);PP17=len(a['pp']);GP17=len(a['gp'])
    def find(dx, P, key):
        for rng, positions in zip(P['sh'], P['sh_solpos']):
            if struct.unpack_from('<I', dx, rng[0])[0] == key:
                return rng, positions
        return None, None
    # dst solution idx -> src solution idx to graft from
    graft = {}
    for nm in names:
        key = hashquick(nm.lower())
        drng, dpos = find(d17, a, key)
        srng, spos = find(d18, b, key)
        if drng is None or srng is None: continue
        # src states indexed by (state with byte14 zeroed) for counterpart matching
        src_by_neutral = {}
        for p in spos:
            v = struct.unpack_from('<H', d18, p)[0]
            st = bytearray(slc(d18, b['state'][v]))
            if st[14] != 0x09: continue
            st[14] = 0
            src_by_neutral[bytes(st)] = v
        n_here = 0
        for p in dpos:
            v = struct.unpack_from('<H', d17, p)[0]
            st = bytearray(slc(d17, a['state'][v]))
            if st[14] not in (0x01, 0x04): continue
            st[14] = 0
            sj = src_by_neutral.get(bytes(st))
            if sj is None: continue
            graft[v] = sj; n_here += 1
        if n_here:
            import sys as _s; _s.stderr.write(f"[transplant] path 0x{a['path_id']:X} {nm}: {n_here} solution(s) grafted\n")
    if not graft:
        return slc(d17, (a['ver_rp_start'], a['db_end'])), 0
    # perms the grafted src solutions need
    need_vp=set(); need_pp=set(); need_gp=set()
    src_refs = {}
    for dv, sj in graft.items():
        sr=b['sol'][sj][0]; vp,pp,gp,vc,pc=struct.unpack_from('<5q',d18,sr+24)
        src_refs[dv]=(vp,pp,gp,vc,pc)
        if vp!=-1: need_vp.add(vp)
        if pp!=-1: need_pp.add(pp)
        if gp!=-1: need_gp.add(gp)
    vp_lst=sorted(need_vp); vp_map={o:i for i,o in enumerate(vp_lst)}
    pp_lst=sorted(need_pp); pp_map={o:i for i,o in enumerate(pp_lst)}
    gp_lst=sorted(need_gp); gp_map={o:i for i,o in enumerate(gp_lst)}
    db=bytearray(); db+=struct.pack('<II',182,a['path_id'])
    def emit(n, blob):
        nonlocal db; db+=struct.pack('<I',n); db+=blob
    def cat(dx, ranges):
        o=bytearray()
        for r in ranges: o+=dx[r[0]:r[1]]
        return bytes(o)
    emit(C17+len(b['const']), cat(d17,a['const'])+cat(d18,b['const']))
    emit(CF17+len(b['cf']), cat(d17,a['cf'])+cat(d18,b['cf']))
    emit(TF17+len(b['tf']), cat(d17,a['tf'])+cat(d18,b['tf']))
    def perm_sliced(lst, ranges, idxs):
        o=bytearray()
        for old in lst:
            rng=ranges[old]; buf=bytearray(slc(d18,rng)); loc=idxs[old]-rng[0]
            for k,off in ((0,C17),(4,CF17),(8,TF17)):
                v=struct.unpack_from('<I',buf,loc+k)[0]
                if v!=NONE: struct.pack_into('<I',buf,loc+k, v+off)
            o+=buf
        return bytes(o)
    emit(VP17+len(vp_lst), cat(d17,a['vp'])+perm_sliced(vp_lst,b['vp'],b['vp_idx']))
    emit(PP17+len(pp_lst), cat(d17,a['pp'])+perm_sliced(pp_lst,b['pp'],b['pp_idx']))
    emit(GP17+len(gp_lst), cat(d17,a['gp'])+cat(d18,[b['gp'][o] for o in gp_lst]))
    # solutions: dst's, with the grafted ones' 5 refs OVERWRITTEN (state hash bytes [0:8] untouched)
    sol_blob=bytearray()
    for i, rng in enumerate(a['sol']):
        buf=bytearray(slc(d17,rng))
        if i in graft:
            vp,pp,gp,vc,pc=src_refs[i]
            newrefs=[VP17+vp_map[vp] if vp!=-1 else -1,
                     PP17+pp_map[pp] if pp!=-1 else -1,
                     GP17+gp_map[gp] if gp!=-1 else -1,
                     C17+vc if vc!=-1 else -1,
                     C17+pc if pc!=-1 else -1]
            for k,v in enumerate(newrefs):
                struct.pack_into('<q', buf, 24+k*8, v)
        sol_blob+=buf
    emit(len(a['sol']), bytes(sol_blob))
    emit(len(a['state']), cat(d17,a['state']))
    emit(len(a['decl'])+len(b['decl']), cat(d17,a['decl'])+cat(d18,b['decl']))
    emit(len(a['sh']), cat(d17,a['sh']))
    return bytes(db), len(graft)


def merge(d17, d18, out_path, keep_hash=None, sub=None, remap=None):
    P17=parse_container(d17); P18=parse_container(d18)
    # match render paths by path_id
    m18={p['path_id']:p for p in P18}
    merged_dbs=[]
    for a in P17:
        b=m18.get(a['path_id'])
        if b is None:
            merged_dbs.append((a['path_id'], slc(d17, (a['ver_rp_start'], a['db_end']))))
            continue
        merged_dbs.append((a['path_id'], merge_db(d17,a,d18,b,keep_hash,sub,remap)))
    # rebuild container
    out=bytearray(); out+=struct.pack('<I', len(merged_dbs))
    for path,db in merged_dbs:
        out+=struct.pack('<II', path, len(db)); out+=db
    open(out_path,'wb').write(out)
    return len(out), len(merged_dbs)

def merge_db(d17,a,d18,b,keep_hash=None,sub=None,remap=None):
    # sub = (target_hash_in_MP017, source_hash_in_MP018): replace target's SurfaceShaderInfo
    #       with source's (re-indexed), keeping target's keyHash. Drops MP_018 shader entries.
    C17=len(a['const']); CF17=len(a['cf']); TF17=len(a['tf'])
    VP17=len(a['vp']); PP17=len(a['pp']); GP17=len(a['gp']); S17=len(a['sol'])
    def add4(buf, pos_in_buf, off):
        v=struct.unpack_from('<I',buf,pos_in_buf)[0]+off
        struct.pack_into('<I',buf,pos_in_buf,v)
    def patch_perm(buf, base, ip):
        # ip absolute = base+local; local index pos for cIdx,cfIdx,tfIdx
        loc=ip-base
        add4(buf, loc+0, C17); add4(buf, loc+4, CF17); add4(buf, loc+8, TF17)
    def patch_sol(buf, base, ip):
        loc=ip-base  # 5 i64 at loc
        offs=[VP17,PP17,GP17,C17,C17]
        for k,o in enumerate(offs):
            v=struct.unpack_from('<q',buf,loc+k*8)[0]
            if v!=-1: struct.pack_into('<q',buf,loc+k*8, v+o)
    # sections that just concat
    def cat(key): return slc17_all(d17,a[key]) , slc17_all(d18,b[key])
    def slc17_all(d, ranges):
        out=bytearray()
        for rng in ranges: out+=slc(d,rng)
        return bytes(out)
    db=bytearray()
    db+=struct.pack('<II',182,a['path_id'])
    def emit(n, blob):
        nonlocal db; db+=struct.pack('<I',n); db+=blob
    # const, cf, tf : verbatim concat (MP_018 const optionally texture-remapped)
    if remap:
        c18=bytearray()
        for rng in b['const']:
            cb=bytearray(slc(d18,rng)); patch_const_block_textures(cb, remap); c18+=cb
        emit(C17+len(b['const']), slc17_all(d17,a['const'])+bytes(c18))
    else:
        emit(C17+len(b['const']), slc17_all(d17,a['const'])+slc17_all(d18,b['const']))
    emit(CF17+len(b['cf']),   slc17_all(d17,a['cf'])  +slc17_all(d18,b['cf']))
    emit(TF17+len(b['tf']),   slc17_all(d17,a['tf'])  +slc17_all(d18,b['tf']))
    # vp : 17 verbatim + 18 patched
    emit(VP17+len(b['vp']), slc17_all(d17,a['vp']) + build_section(d18,b['vp'],b['vp_idx'],patch_perm))
    emit(PP17+len(b['pp']), slc17_all(d17,a['pp']) + build_section(d18,b['pp'],b['pp_idx'],patch_perm))
    emit(GP17+len(b['gp']), slc17_all(d17,a['gp']) + slc17_all(d18,b['gp']))
    # solutions + states : build MP_018 block (patch perm/const idx; if sub, rename Water states & recompute StateHash)
    if sub is not None:
        tgt_key, src_key, tgt_name, src_name = sub
        sol18=bytearray(); state18=bytearray(); renamed=0
        for k in range(len(b['sol'])):
            solrng=b['sol'][k]; strng=b['state'][k]
            sbuf=bytearray(slc(d18,solrng)); patch_sol(sbuf, solrng[0], b['sol_idx'][k])
            stbuf=bytearray(slc(d18,strng))
            if struct.unpack_from('<I',stbuf,0)[0]==src_name:
                struct.pack_into('<I',stbuf,0,tgt_name)
                struct.pack_into('<Q',sbuf,0, fletcher64(bytes(stbuf)))
                renamed+=1
            sol18+=sbuf; state18+=stbuf
        import sys as _s; _s.stderr.write(f"[sub] renamed {renamed} Water states -> Sea_Shader\n")
        emit(S17+len(b['sol']), slc17_all(d17,a['sol']) + bytes(sol18))
        emit(len(a['state'])+len(b['state']), slc17_all(d17,a['state']) + bytes(state18))
    else:
        emit(S17+len(b['sol']), slc17_all(d17,a['sol']) + build_section(d18,b['sol'],b['sol_idx'],patch_sol))
        emit(len(a['state'])+len(b['state']), slc17_all(d17,a['state'])+slc17_all(d18,b['state']))
    # declarations : verbatim concat
    emit(len(a['decl'])+len(b['decl']), slc17_all(d17,a['decl'])+slc17_all(d18,b['decl']))
    if sub is not None:
        tgt_hash, src_hash = sub[0], sub[1]
        # extract MP_018's source SurfaceShaderInfo bytes (after the keyHash u32), reindex sol refs
        src_info=None
        for rng,positions in zip(b['sh'], b['sh_solpos']):
            if struct.unpack_from('<I',d18,rng[0])[0]==src_hash:
                buf=bytearray(slc(d18,rng))
                for p in positions:
                    loc=p-rng[0]
                    struct.pack_into('<H',buf,loc, struct.unpack_from('<H',buf,loc)[0]+S17)
                src_info=bytes(buf[4:])   # drop keyHash u32
                break
        assert src_info is not None, "source shader not found in MP_018"
        # MP_017 shaders: substitute target's SurfaceShaderInfo, keep its keyHash; no MP_018 entries appended
        sh17=bytearray(); subbed=0
        for rng in a['sh']:
            keyhash=struct.unpack_from('<I',d17,rng[0])[0]
            if keyhash==tgt_hash:
                sh17+=struct.pack('<I',keyhash)+src_info; subbed+=1
            else:
                sh17+=slc(d17,rng)
        assert subbed==1, f"target shader matched {subbed} times"
        emit(len(a['sh']), bytes(sh17))
        return bytes(db)
    # shaders : 17 verbatim + 18 with solution-idx patched (optionally only keep_hash)
    sh18=bytearray(); kept=0
    for rng,positions in zip(b['sh'], b['sh_solpos']):
        keyhash=struct.unpack_from('<I',d18,rng[0])[0]
        if keep_hash is not None and keyhash!=keep_hash:
            continue
        buf=bytearray(slc(d18,rng))
        for p in positions:
            loc=p-rng[0]
            v=struct.unpack_from('<H',buf,loc)[0]+S17
            struct.pack_into('<H',buf,loc,v)
        sh18+=buf; kept+=1
    emit(len(a['sh'])+kept, slc17_all(d17,a['sh'])+bytes(sh18))
    return bytes(db)

def clone_shader(dbpath, srcname, newname, out_path):
    """Duplicate the shader entry `srcname` under a NEW keyHash = hashquick(newname), pointing at the
       SAME solutions (shared). New key => registers (does not conflict with the level's own entry).
       All other sections verbatim; appends ONE shader entry per render-path db that has srcname."""
    d=open(dbpath,'rb').read()
    P=parse_container(d)
    src_hash=hashquick(srcname.lower()); new_hash=hashquick(newname.lower())
    merged=[]; cloned=0
    for a in P:
        src_rng=None
        for rng in a['sh']:
            if struct.unpack_from('<I',d,rng[0])[0]==src_hash: src_rng=rng; break
        if src_rng is None:
            merged.append((a['path_id'], slc(d,(a['ver_rp_start'],a['db_end'])))); continue
        clone=bytearray(slc(d,src_rng)); struct.pack_into('<I',clone,0,new_hash)
        sh_count_pos=a['sh'][0][0]-4
        newdb=bytearray()
        newdb+=d[a['ver_rp_start']:sh_count_pos]
        newdb+=struct.pack('<I',len(a['sh'])+1)
        newdb+=d[a['sh'][0][0]:a['db_end']]
        newdb+=bytes(clone)
        merged.append((a['path_id'], bytes(newdb))); cloned+=1
    cont=bytearray(); cont+=struct.pack('<I',len(merged))
    for path,db in merged: cont+=struct.pack('<II',path,len(db))+db
    open(out_path,'wb').write(cont)
    return cloned, src_hash, new_hash

if __name__=='__main__':
    cmd=sys.argv[1]
    if cmd=='cloneshader':
        # cloneshader <db> <out> <srcExactName> <newExactName>
        cloned,sh,nh=clone_shader(sys.argv[2], sys.argv[4], sys.argv[5], sys.argv[3])
        print(f"cloned '{sys.argv[4]}'(0x{sh:08X}) -> '{sys.argv[5]}'(0x{nh:08X}) in {cloned} render-path db(s) -> {sys.argv[3]}")
        parse_container(open(sys.argv[3],'rb').read()); print("RE-PARSE OK")
        raise SystemExit
    if cmd=='check':
        d=open(sys.argv[2],'rb').read()
        P=parse_container(d)
        for p in P:
            print(f"path 0x{p['path_id']:X}: const={len(p['const'])} cf={len(p['cf'])} tf={len(p['tf'])} "
                  f"vp={len(p['vp'])} pp={len(p['pp'])} gp={len(p['gp'])} sol={len(p['sol'])} "
                  f"state={len(p['state'])} decl={len(p['decl'])} sh={len(p['sh'])}")
        print("PARSE OK, total", len(d))
    elif cmd=='merge':
        d17=open(sys.argv[2],'rb').read(); d18=open(sys.argv[3],'rb').read()
        keep=None
        if len(sys.argv)>5:
            keep=hashquick(sys.argv[5]); print(f"keep only shader '{sys.argv[5]}' hash=0x{keep:08X}")
        n,k=merge(d17,d18,sys.argv[4],keep)
        print(f"merged {k} render-path db(s) -> {sys.argv[4]} ({n} bytes)")
        parse_container(open(sys.argv[4],'rb').read())
        print("RE-PARSE OK")
    elif cmd=='retex':
        # retex <db> <out> old::new [old::new ...]
        d=open(sys.argv[2],'rb').read()
        remap={}
        for pair in sys.argv[4:]:
            if "::" in pair: o,nw=pair.split("::",1); remap[o]=nw
        n=retex(d, sys.argv[3], remap)
        print(f"retex -> {sys.argv[3]} ({n} blocks)")
        parse_container(open(sys.argv[3],'rb').read()); print("RE-PARSE OK")
    elif cmd=='pad':
        # pad <db> <out> <target_bytes>
        d=open(sys.argv[2],'rb').read()
        n=pad(d, sys.argv[3], int(sys.argv[4]))
        print(f"padded -> {sys.argv[3]} ({n} bytes)")
        parse_container(open(sys.argv[3],'rb').read()); print("RE-PARSE OK")
    elif cmd=='appendshader':
        # appendshader <targetdb> <srcdb> <out> <srcExactName> [remap pairs old::new ...]
        d17=open(sys.argv[2],'rb').read(); d18=open(sys.argv[3],'rb').read()
        src_exact=sys.argv[4+1]
        remap={}
        for pair in sys.argv[6:]:
            if "::" in pair:
                o,nw=pair.split("::",1); remap[o]=nw
        n,k=merge_append(d17,d18,sys.argv[4],src_exact,remap or None)
        print(f"appended '{src_exact}' -> {sys.argv[4]} ({n} bytes, {k} render-path db(s))")
        parse_container(open(sys.argv[4],'rb').read()); print("RE-PARSE OK")
    elif cmd=='swapentry':
        # swapentry <dstdb> <srcdb> <out> <exactName> : replace the dst's OWN entry for an existing
        # key with the src's full entry (sliced sols/perms, re-indexed) — the probe for whether an
        # EXTENDED entry (mergesol) vs a REPLACED entry behaves differently in-engine.
        d17=open(sys.argv[2],'rb').read(); d18=open(sys.argv[3],'rb').read()
        n,k=merge_append(d17,d18,sys.argv[4],sys.argv[5],None,swap=True)
        print(f"swapentry '{sys.argv[5]}' -> {sys.argv[4]} ({n} bytes, {k} render-path db(s))")
        parse_container(open(sys.argv[4],'rb').read()); print("RE-PARSE OK")
    elif cmd=='transplant':
        # transplant <dstdb> <srcdb> <out> <name1,name2,...> : graft the src's 09-variant compiled
        # perms onto the dst's NATIVE 01/04 solutions (states untouched) for the named shaders.
        d17=open(sys.argv[2],'rb').read(); d18=open(sys.argv[3],'rb').read()
        names=[x for x in sys.argv[5].split(',') if x]
        n,k=transplant_solutions(d17,d18,sys.argv[4],names)
        if k==0:
            print("transplant: no graftable solutions, no file written")
        else:
            print(f"transplant -> {sys.argv[4]} ({n} bytes, {k} solution(s) grafted)")
            parse_container(open(sys.argv[4],'rb').read()); print("RE-PARSE OK")
    elif cmd=='mergesol':
        # mergesol <dstdb> <srcdb> <out> <name1,name2,...> : union-extend PRESENT dst entries with the
        # src entries' solutions whose SolutionState is missing (the grey-foreign-vehicle fix).
        d17=open(sys.argv[2],'rb').read(); d18=open(sys.argv[3],'rb').read()
        names=[x for x in sys.argv[5].split(',') if x]
        n,k=merge_solutions(d17,d18,sys.argv[4],names)
        if k==0:
            print("mergesol: nothing missing, no file written")
        else:
            print(f"mergesol -> {sys.argv[4]} ({n} bytes, +{k} solution(s))")
            parse_container(open(sys.argv[4],'rb').read()); print("RE-PARSE OK")
    elif cmd=='hashcheck':
        d=open(sys.argv[2],'rb').read(); P=parse_container(d)
        a=P[0]
        ok=0; bad=0
        for i in range(min(50,len(a['sol']))):
            srng=a['sol'][i]; strng=a['state'][i]
            stored=struct.unpack_from('<Q',d,srng[0])[0]
            calc=fletcher64(d[strng[0]:strng[1]])
            if stored==calc: ok+=1
            else: bad+=1;
            if i<3: print(f"sol{i}: stored=0x{stored:016X} calc=0x{calc:016X} {'OK' if stored==calc else 'MISMATCH'}")
        print(f"checked 50: ok={ok} bad={bad}")
    elif cmd=='has':
        # has <db> <shaderExactName> : print PRESENT/ABSENT (is the shader's keyHash in the db?)
        d=open(sys.argv[2],'rb').read(); P=parse_container(d)
        key=hashquick(sys.argv[3].lower())
        found=any(struct.unpack_from('<I',d,rng[0])[0]==key for a in P for rng in a['sh'])
        print("PRESENT" if found else "ABSENT")
    elif cmd=='tex2':
        # tex2 <db> <shaderExactName> : full chain — solutions -> perms+constants -> TextureConstant names
        d=open(sys.argv[2],'rb').read(); P=parse_container(d)
        key=hashquick(sys.argv[3].lower())
        def const_textures(crange):
            cs=crange[0]
            tco=struct.unpack_from('<Q',d,cs+16)[0]
            tcc=d[cs+53]
            out=[]; p=cs+tco
            for _ in range(tcc):
                nm=d[p+8:p+8+128].split(b'\x00')[0].decode('latin1'); out.append(nm); p+=152
            return out
        allnames=set()
        for a in P:
            # find water solution indices
            solidx=None
            for rng,positions in zip(a['sh'],a['sh_solpos']):
                if struct.unpack_from('<I',d,rng[0])[0]==key:
                    solidx=[struct.unpack_from('<H',d,p)[0] for p in positions]; break
            if solidx is None: continue
            cidx=set()
            for si in solidx:
                sr=a['sol'][si][0]
                vp,pp,gp,vc,pc=struct.unpack_from('<5q',d,sr+24)
                if vp!=-1: cidx.add(struct.unpack_from('<I',d,a['vp_idx'][vp])[0])
                if pp!=-1: cidx.add(struct.unpack_from('<I',d,a['pp_idx'][pp])[0])
                if vc!=-1: cidx.add(vc)
                if pc!=-1: cidx.add(pc)
            for ci in cidx:
                for nm in const_textures(a['const'][ci]):
                    if nm: allnames.add(nm)
            print(f"path 0x{a['path_id']:X}: {len(cidx)} constants referenced")
        print("=== textures sampled by shader ===")
        for n in sorted(allnames): print("   ",n)
    elif cmd=='textures':
        # textures <db> <shaderExactName> : list StreamableTextures + ExternalTextures the shader samples
        d=open(sys.argv[2],'rb').read(); P=parse_container(d)
        key=hashquick(sys.argv[3].lower())
        for a in P:
            for rng in a['sh']:
                if struct.unpack_from('<I',d,rng[0])[0]!=key: continue
                o=rng[0]+4          # skip keyHash
                o+=4                # surfType
                o+=4                # flags,boolCnt,defMask,reqMask
                o+=32               # 8*u32 boolIds
                nST=struct.unpack_from('<I',d,o)[0]; o+=4
                print(f"path 0x{a['path_id']:X}: {nST} StreamableTextures:")
                for _ in range(nST):
                    e=d.index(0,o); name=d[o:e].decode('latin1'); o=e+1
                    coord,vu=struct.unpack_from('<II',d,o); o+=8; o+=4  # +factor
                    print(f"    {name}")
                nSET=struct.unpack_from('<I',d,o)[0]; o+=4
                print(f"  {nSET} StreamableExternalTextures (param names):")
                for _ in range(nSET):
                    e=d.index(0,o); name=d[o:e].decode('latin1'); o=e+1
                    o+=4  # paramId
                    coord,vu=struct.unpack_from('<II',d,o); o+=8; o+=4
                    print(f"    [ext] {name}")
                break
    elif cmd=='multisub':
        # multisub <mp17> <mp18> <out> target::source [target::source ...] [oldtex=newtex ...]
        d17=open(sys.argv[2],'rb').read(); d18=open(sys.argv[3],'rb').read()
        subs=[]; remap={}
        for arg in sys.argv[5:]:
            if '::' in arg:
                t,s=arg.split('::'); subs.append((t,s))
            elif '=' in arg:
                o,nw=arg.split('='); remap[o]=nw
        print("subs:",subs); print("remap:",remap)
        n,k=merge_multi(d17,d18,sys.argv[4],subs,remap or None)
        print(f"wrote {sys.argv[4]} ({n} bytes)")
        parse_container(open(sys.argv[4],'rb').read()); print("RE-PARSE OK")
    elif cmd=='analyze':
        # analyze <db> <shaderExactName>
        d=open(sys.argv[2],'rb').read(); P=parse_container(d)
        key=hashquick(sys.argv[3].lower())
        print(f"shader '{sys.argv[3]}' keyHash(lower)=0x{key:08X} name(exact)=0x{hashquick(sys.argv[3]):08X}")
        for a in P:
            found=False
            for rng,positions in zip(a['sh'], a['sh_solpos']):
                if struct.unpack_from('<I',d,rng[0])[0]==key:
                    found=True
                    solidx=[struct.unpack_from('<H',d,p)[0] for p in positions]
                    namehashes=set()
                    for si in solidx[:200]:
                        strng=a['state'][si]
                        namehashes.add(struct.unpack_from('<I',d,strng[0])[0])
                    print(f"  path 0x{a['path_id']:X}: {len(solidx)} solutions; distinct state SurfaceShaderNameHash:",
                          [f"0x{h:08X}" for h in namehashes])
            if not found: print(f"  path 0x{a['path_id']:X}: shader entry NOT found")
    elif cmd=='sub':
        # sub <mp17db> <mp18db> <out> <targetExactName MP17> <sourceExactName MP18>
        d17=open(sys.argv[2],'rb').read(); d18=open(sys.argv[3],'rb').read()
        tgt_exact=sys.argv[5]; src_exact=sys.argv[6]
        th_key=hashquick(tgt_exact.lower()); sh_key=hashquick(src_exact.lower())
        th_name=th_key; sh_name=sh_key   # state SurfaceShaderNameHash == lowercase keyHash (confirmed via analyze)
        print(f"target '{tgt_exact}' key=0x{th_key:08X} name=0x{th_name:08X}")
        print(f"source '{src_exact}' key=0x{sh_key:08X} name=0x{sh_name:08X}")
        remap=None
        if len(sys.argv)>7:
            # extra args: oldtex=newtex pairs
            remap={}
            for pair in sys.argv[7:]:
                o,nw=pair.split('='); remap[o]=nw
            print("texture remap:",remap)
        n,k=merge(d17,d18,sys.argv[4],sub=(th_key,sh_key,th_name,sh_name),remap=remap)
        print(f"wrote {sys.argv[4]} ({n} bytes)")
        parse_container(open(sys.argv[4],'rb').read()); print("RE-PARSE OK")

		clearlistener();
		
		--Short to 16bit Half float conversion function
	fn readHalfFloat fstream = (
	    hf=readshort fstream #unsigned
	    sign = bit.get hf 16
	    exponent = (bit.shift (bit.and hf (bit.hexasint "7C00")) -10) as integer - 16
	    fraction = bit.and hf (bit.hexasint "03FF")
	    if sign==true then sign = 1 else sign = 0
	    exponentF = exponent + 127
	    outputAsFloat = bit.or (bit.or (bit.shift fraction 13) \
	    (bit.shift exponentF 23)) (bit.shift sign 31)
	    return bit.intasfloat outputasfloat*2
	    )
	--Vert selection function	
	fn findItemIndexes arr = (
			local usedValues = #()
			local indexes = #()
			for i = 1 to arr.count do (
				local j = findItem usedValues arr[i]
				if j == 0 then (
					append usedValues arr[i]
					append indexes #{i}
				) else
					indexes[j][i] = on
			)
			indexes
		)
		--Detach to object using vert_array selection and assingind new object name via "By Reference Parameter Passing"
	fn detachObj obj vertArr outName  = (
	    -- cache modifier to variable
	    if obj.modifiers[#Edit_Poly] != undefined then (
	        epMod = obj.modifiers[#Edit_Poly]
	    ) else (
	        epMod = edit_poly()
	        addmodifier obj epMod		
	    )
	    -- set modifier active in modpanel
	    modpanel.setCurrentObject epMod
	    -- set SO Level
	    subobjectLevel = 1
	    -- set Vertex Selection using supplied BitArray
	    epMod.Select #Vertex &vertArr
	    -- detach the object and setname using by-reference variable
	    epMod.DetachToObject &outname
	    -- delete modifier
	    deletemodifier obj epMod
	)	
		-- open file dialog to import .mesh file
		
		Mesh_filename = getOpenFileName caption:"Import Mesh File" types:"MeshFile (*.mesh)|*.mesh|All Files (*.*)|*.*"
		if Mesh_filename != undefined then mFile = fopen Mesh_filename "rb"
			
		
		
		Texture_Path = replace mesh_filename (mesh_filename.count-4) 5 ".dds"--(((getFilenamePath mesh_filename)+((trimright (filenameFromPath mesh_filename)".mesh"))+".png"))

		
		cur_path = getFilenamePath (getThisScriptFilename())
	

		filein (cur_path + @"\TransformFunctions.ms")
		
		--Texture_Path = getOpenFileName caption:"Select first texture file" types:"MeshFile (*.png)|*.png|(*.dds)|*.dds|All Files (*.*)|*.*"
		
	  	-- attempt to concatenate chunkfile`s path from meshfile
	 	Chunk_filename = replace mesh_filename (mesh_filename.count-4) 5 ".chunk"
		C_File = fopen Chunk_filename "rb"
		--if concatenation fails open a new file dialog
		if C_file== undefined do( 
		Chunk_filename = getOpenFileName caption:"Import Chunk File" types:"ChunkFile (*.chunk)|*.chunk|All Files (*.*)|*.*"
		if Chunk_filename != undefined then C_File = fopen Chunk_filename "rb")

		clearlistener();
													"Frostbite model importer by Dainius G 2014, tested on 3ds max 2012x64"
		First_Data_Block_Offset = 0
		Mesh_Object_Count = 0
		ObjectFullPathName = ""
		ObjectFullName= ""
		ObjectType=0
		GUID_Count=0
		FaceIndiceOffset=0
		Last_Vert_pos=0
		submesh_vert_count=0
		VB_Size=0
		vert_start_pos=0
		last_face_indice_pos =0
		read_vert_pos_value=readHalfFloat
		Model_Scale = 39
		Submesh_Material_Name=""
		mesh_rotation = 90


		Inc1 = 0 
		Inc2 = 1
		Inc3 = 8----------------------this offsets the first read out section
		Var1 = 0
		
		Increment_For_Vert_position=0
		
		B=0
		Vert_Bone_Indices_array=#()
		Vert_Blend_Weights_Array=#()
		
			--First readouts from .mesh file
	  
		(	
			fseek mFile (80+Inc3) #seek_set 
			ObjectFullPathName_Position = readshort mFile #unsigned
			fseek mFile ObjectFullPathName_Position #seek_set 
			print	("ObjectFullPathName " + (ObjectFullPathName = readstring mFile ))
				
			fseek mFile (88+Inc3) #seek_set 
				ObjectFullName_Position = readshort mFile #unsigned

			fseek mFile ObjectFullName_Position #seek_set 
			print	("ObjectFullName " + (ObjectFullName = readstring mFile))as string

			fseek mFile (100+Inc3) #seek_set
			print	("ObjectType " + (ObjectType = readShort mFile #unsigned)as string)
	  
			fseek mFile (140) #seek_set
			print	("GUID_Count " + (GUID_Count = readShort mFile #unsigned)as string)
				
			print	("Total_Submesh_Count " + (Total_Submesh_Count = readShort mFile #unsigned)as string)	
				
			fseek mFile 156 #seek_set
			print	("First_Data_Block_Offset " + (First_Data_Block_Offset = readshort mFile #unsigned)as string)	
			
			fseek mFile 164 #seek_set
			print	("Mesh_Object_Count " + (Mesh_Object_Count = readShort mFile #unsigned)as string)
			
			fseek mFile 228 #seek_set
			print	("Mesh_FaceIndice_Format " + (global face_indiceformat = readShort mFile #unsigned)as string) 				
											
			fseek mFile 236 #seek_set
				"FaceIndiceOffset "+ (FaceIndiceOffset = (readlong mFile))as string

			fseek mFile 4 #seek_cur
			fn guidRead_Fn id = (id="" for i = 1 to 16 do 
						(	
							(b = bit.intashex(readbyte mFile))
							if b.count<2 do b=("0"+b)
							if b.count>2 do b=(substring b (7)(2))	
							append id b
						)
				return id
			)
			print ("GUID " + guidRead_Fn id)
-----------------------------------------------------------Face indice calculations----BEGINS-----------------------------------------------------------------------------------------
			fseek mfile First_Data_Block_Offset #seek_set
		
			global	primarr=#()
			global	indicesize=#()		
			for i = 1 to Mesh_Object_Count do 
			(
				fseek mfile 32 #seek_cur
					
					append primarr ((readlong mfile)*3)
					append indicesize ((readlong mfile))

				fseek mfile 264 #seek_cur
				)	
			append indicesize primarr[primarr.count]
					
					
-----------------------------------------------------------Face indice calculations----ENDS-----------------------------------------------------------------------------------------

					
				)

				Vert_Positions_F = 		769 -- float
				Vert_Positions_HF = 	1793 --halfFloat
				Vert_Unknown_Flag1 = 	1289
				Vert_BiNormals = 		2054 
				Vert_Tangents = 		2055 
				Vert_Normals_UV = 		1569  
				Vert_Diffuse_UV =		1570 
				Vert_Bone_Indices =		3074 			
				Vert_Blend_Weights = 	3332
				Vert_Unknown_Flag2 = 	3358 --for vehicles
				Vert_Unknown_Flag3 =	2056
				Vert_Unknown_Flag4 = 	1571
				
				VB_Flag_Name_Strings = #("Vert_Positions_F","Vert_Positions_HF","Vert_Unknown_Flag1","Vert_BiNormals","Vert_Tangents","Vert_Diffuse_UV","Vert_Normals_UV","Vert_Bone_Indices","Vert_Blend_Weights","Vert_Unknown_Flag2","Vert_Unknown_Flag3")
				VB_Flags = #(Vert_Positions_F,Vert_Positions_HF,Vert_Unknown_Flag1,Vert_BiNormals,Vert_Tangents,Vert_Diffuse_UV,Vert_Normals_UV,Vert_Bone_Indices,Vert_Blend_Weights,Vert_Unknown_Flag2,Vert_Unknown_Flag3,Vert_Unknown_Flag4)
				
				bone_Order_array=#()
				
				
				
				
				
				parts_array_pos=#()
				parts_array_rot=#()
				Pnt_arr=#()
						
				If ObjectType==2 or ObjectType==0 do
			(
				--fseek mfile 0 #seek_set
				this = 144 --lod1 MeshLayout infomation start
				
				m_partCount=0	
				fseek mfile (this+164)  #seek_set		
							print	("m_partCount                	" + (m_partCount= readlong mfile)as string) --unsigned int // 0x94
							
							fseek mfile (BboxOffset = readlong mfile) #seek_set
							m_partBoundingBoxes=#() 
								for i = 1 to m_partCount do /*	union fb::RelocPtr<fb::AxisAlignedBox>*/--void*   // 0x98
									(
										_min=#(readfloat mfile,readfloat mfile,readfloat mfile,readfloat mfile)
										_max=#(readfloat mfile,readfloat mfile,readfloat mfile,readfloat mfile)	
										append m_partBoundingBoxes #(_min,_max)								
									)
							fseek mfile (this+168) #seek_set
							fseek mfile ((readlong mfile)+(m_partCount*32))#seek_set
							print ("before parts "+(ftell mfile as string))
							m_partTransforms=#()
									for i = 1 to m_partCount do   /*	union fb::RelocPtr<fb::LinearTransform> */--void*  // 0xA0
									(
										p=LinearTransform()
										Pnt=point transform:(matrix3 p[1]p[2]p[3](p[4]*model_scale))--position:(p[4]*model_scale)                      --rotation:(quat (p[1][1])(p[1][2])(p[1][3])(p[1][4])) --name:(SubSet_InfoArray[Lod_int][2] +"	"+ i as string)
										append Pnt_arr Pnt
										append parts_array_pos (p[4]*model_scale)
										append parts_array_rot (quat p[1][1]p[1][2]p[1][3]p[1][4])
										--append parts_array_pos (matrix3 p[1]p[2]p[3]p[4])
									)
				 this+=192
			)
			global_parts_pos_test_array=#()
				
				
				
				

				
				
				
				
				for sub_m = 1 to (mesh_object_count) do
		(		
					
			
					print "------------------------------"
					print ("loop"+(Inc2)as string)
					
					fseek mFile (First_Data_Block_Offset+Inc1+48) #seek_set
					print (("Submesh_"+ (Inc2)as string) + "_VB_Size "  + (VB_Size = readbyte mFile #unsigned)as string)
					print (("Submesh_"+ (Inc2)as string) + "_PrimitiveType "  + (_PrimitiveType = readbyte mFile #unsigned)as string)
					fseek mfile 14 #seek_cur
					print (("Submesh_"+ (Inc2)as string) + "_BonesPerVertex "  + (_BonesPerVertex = readbyte mFile #unsigned)as string)
					print (("Submesh_"+ (Inc2)as string) +"_"+ "BoneCount_From_Order "  + (BoneCount_From_Order = readbyte mFile #unsigned)as string)

					
					
					
					--For each submesh in the file except the one that has VB size less than 20 ( usually means it`s useless)
					if VB_Size > 20 then 
			(
					VB_positions=#()
					bone_Order_array=#()
						
					-- Read BoneOrderOffset And read Bone Order info into array
					fseek mfile 2 #seek_cur
					BoneOrderOffset = readlong mFile	
					
					fseek mFile (BoneOrderOffset) #seek_set
					

					for bn_ord = 1 to BoneCount_From_Order do 
						(
							b = readshort mFile
							append bone_Order_array b	
						)					
						
	-- 				for i in bone_Order_array do 
	-- 					print bnarr[i+1]
					
					
					fseek mFile (First_Data_Block_Offset+Inc1) #seek_set	

					fseek mFile 16 #seek_cur
					Submesh_Mat_Name_Offset = readlonglong mFile
				
					fseek mFile 8 #seek_cur
					print (("Submesh_"+ (Inc2)as string) +"_Primitive_Count "+(Submesh_Primitive_Count = readlong mFile #unsigned)as string)
						
					fseek mFile 8 #seek_cur
					print (("Submesh_"+ (Inc2)as string) +"_Vert_Count "+(Submesh_Vert_Count = readlong mFile #unsigned)as string)
					
					--next 4 one byte values (VB_Size, PrimitiveType,BonesPerVert,BoneCount) are already read above in lines 160>164
					
					--ftell mfile 
					
					fseek mFile (12+16) #seek_cur
					for zulu = 1 to 30 do
						(
							append VB_positions (readshort mFile)
							)
														
					--fseek mFile (First_Data_Block_Offset+Inc1+220) #seek_set
							
--------------------------------------------------------------------------------------------------FACE INDICE Counting might need to be switched here--------------------------------------------------------------------------------------------------------------------------		
					print (("Submesh_"+ (Inc2)as string) + "_Face_Indice_Count " +(Submesh_Face_Indice_Count = (Submesh_Primitive_Count*3))as string)
						
					--print (("Submesh_"+ (Inc2)as string) + "_Face_Indice_Count " +(global Submesh_Face_Indice_Count = (indicesize[sub_m+1]-indicesize[sub_m]))as string)		
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------			

					fseek mFile Submesh_Mat_Name_Offset #seek_set
					print (("Submesh_" + (Inc2)as string) + "_Material_Name " +(Submesh_Material_Name = readstring mFile )as string)
					
					Inc1 += 304
					Inc2 += 1
					Var1 =  Submesh_Face_Indice_Count
					--if vert_start_pos ==0 then(
					--fseek C_File vert_start_pos #seek_set)
					--else fseek C_File last_vert_pos #seek_set
					
					print ("Position before verts "+((ftell C_File)as string))
					
					var6=1
					ba=0
					
					Vert_Positions_array=#()
					Vert_Tangents_array=#()
					Vert_BiNormals_array=#()
					Vert_Diffuse_Array=#()
					Vert_Normal_Array=#()
					Vert_Bone_Indices_array=#()
					Vert_Blend_Weights_Array=#()
					Face_array=#()
					BoneIndexSameBool=false
					
				
					if VB_positions[1] == Vert_Positions_F 
						then
						(
							read_vert_pos_value=readfloat
							print("VertPosFormat is Float")
						)
						else 
						(
							read_vert_pos_value = readHalfFloat
							print("VertPosFormat is HalfFloat")
						)
					
							--In this section the script reads out data from VertexBlock and appends it to arrays
							for vb_read_array = 1 to submesh_vert_count do
								(
								try(	
									fseek c_file (0 + Increment_For_Vert_position) #seek_set	
									vpx =  read_vert_pos_value c_file 
									vpy =  read_vert_pos_value c_file 
									vpz =  read_vert_pos_value c_file 
									if
									
										vpx != Undefined and vpy!=undefined and vpz!=undefined do
										(
											append Vert_Positions_array [(vpx*model_scale),(vpy*model_scale),(vpz*model_scale)]
										)
									)
								catch 
									if vb_read_array == 1 do 
										(print"Vert_Positions error" 
										messagebox "Vert_Positions error")
								
								try(
									fseek c_file (VB_positions[((finditem VB_positions Vert_Tangents)+1)] + Increment_For_Vert_position) #seek_set 					
									vtx = 	readHalfFloat c_file 
									vty = 	readHalfFloat c_file 
									vtz = 	readHalfFloat c_file
									if
									
										vtx !=Undefined and vty !=Undefined and vtz !=Undefined do
										(
											append Vert_Tangents_array [vtx,vty,vtz]
										)
									)
								catch 
									if vb_read_array == 1 do 
										(print"Vert_Tangents error"
										messagebox "Vert_Tangents error")
								try(
									fseek c_file (VB_positions[((finditem VB_positions Vert_BiNormals)+1)] + Increment_For_Vert_position) #seek_set 
									vnx = readHalfFloat c_file 
									vny = readHalfFloat c_file 
									vnz = readHalfFloat c_file
									if
									
										vnx !=Undefined and vny !=Undefined and vnz !=Undefined do
										(
											append Vert_BiNormals_array [vnx,vny,vnz]
										)
									)
								catch 
									if vb_read_array == 1 do 
									(print "Vert_BiNormals error" 
										messagebox "Vert_BiNormals error")
								
								try(
									fseek c_file (VB_positions[((finditem VB_positions Vert_Diffuse_UV)+1)] + Increment_For_Vert_position) #seek_set 
									v_diff_U = readHalfFloat c_file 
									v_diff_V = readHalfFloat c_file 
									if 
									
										v_diff_U !=Undefined and v_diff_V!=Undefined do
										(
										append Vert_diffuse_Array [v_diff_U,v_diff_V,0]
										)
									)
								catch 
									if vb_read_array == 1 do 
									(print"Vert_diffuse error"
										messagebox "Vert_diffuse error")
									
								try(
									fseek c_file (VB_positions[((finditem VB_positions Vert_Normals_UV)+1)] + Increment_For_Vert_position) #seek_set 							
									v_Norm_U = readHalfFloat c_file 
									v_Norm_V = readHalfFloat c_file 
									if 
									
										v_Norm_U !=Undefined and v_Norm_V!=Undefined do
										(
										append Vert_Normal_Array [v_Norm_U,v_Norm_V,0]
										)
									)
								catch 
									if vb_read_array == 1 do 
									(print"Vert_Normal error"
										messagebox "Vert_Normal error")
								
								try(
									fseek c_file (VB_positions[((finditem VB_Positions Vert_Bone_Indices)+1)] + Increment_For_Vert_position) #seek_set 					
									vbi1 = readbyte c_file #unsigned
									vbi2 = readbyte c_file #unsigned
									vbi3 = readbyte c_file #unsigned
									vbi4 = readbyte c_file #unsigned
									if
									
										vbi1 != Undefined and vbi2 != Undefined and vbi3 != Undefined and vbi4 != Undefined do
										(
										append Vert_Bone_Indices_array [vbi1,vbi2,vbi3,vbi4]
										)									
									)
								catch 
									if vb_read_array == 1 do 
									(print"Vert_Bone_Indices error"
										messagebox "Vert_Bone_Indices error")
									
								try(
									fseek c_file (VB_positions[((finditem VB_Positions Vert_Blend_Weights)+1)] + Increment_For_Vert_position) #seek_set 
									vbw1 = (readbyte c_file #unsigned)as float/255
									vbw2 = (readbyte c_file #unsigned)as float/255
									vbw3 = (readbyte c_file #unsigned)as float/255
									vbw4 = (readbyte c_file #unsigned)as float/255
									if
									
										vbw1 != Undefined and vbw2 != Undefined and vbw3 != Undefined and vbw4 != Undefined do 
										(
										append Vert_Blend_Weights_array [vbw1,vbw2,vbw3,vbw4]				
										)
									)	
								catch 
									if vb_read_array == 1 do 
									(print"Vert_Blend_Weights error"		
										messagebox "Vert_Blend_Weights error")
									
								Increment_For_Vert_position += vb_size							
					)

					if vbi1==vbi2 and vbi2==vbi3 and vbi3==vbi4 then
						(
							BoneIndexSameBool=true
						)
					else 
						(
							BoneIndexSameBool=false
						)
				print ("Position after verts "+((ftell C_File)as string))			
						
						--Read face indices
				if 	FaceIndiceOffset > last_face_indice_pos then(
				fseek C_File FaceIndiceOffset   #seek_set )
				else fseek C_File last_face_indice_pos   #seek_set 
				
				da = readshort c_file
				db = readshort c_file
				fseek c_file -4 #seek_cur				
				f_inc = 0
				readface = readshort
				if da==db do (f_inc=2)
				if face_indiceformat == 46 do
					(
						f_inc=0
						readface = readlong
					)
				fseek c_file f_inc #seek_cur
						
				print ("Position before f-indice`s "+(((a=(ftell c_File)))as string)+"  0x"+bit.intashex a)	

				for x = 1 to Submesh_Face_Indice_Count/3 do
					(					
						fa=readface C_File #unsigned+1
						fb=readface C_File #unsigned+1
						fc=readface C_File #unsigned+1
						
						append Face_array[fa,fb,fc]
					)
						
				print ("Position after f-indice`s "+(((a=(ftell c_file)))as string)+"  0x"+bit.intashex a)					
				Last_Face_Indice_pos = ftell C_File
				
				--Build Mesh From Arrays
				mesh1 = mesh vertices:Vert_Positions_array faces:Face_array
				mesh1.numTVerts = Vert_Diffuse_array.count
				mesh1.name = (trimleft(Submesh_Material_Name)"mat_")
				
				meshop.setNumMaps mesh1 3 keep:false
				channelInfo.Dialog ()	
				channelInfo.NameChannel mesh1 3 1 "Diffuse"
				channelInfo.NameChannel mesh1 3 2 "Normal"
					
				buildTVFaces mesh1	
				meshop.setMapSupport mesh1 1 true
				meshop.setMapSupport mesh1 2 true	
				for j = 1 to Vert_Diffuse_array.count  do  meshop.setMapVert mesh1 2 j Vert_Diffuse_array[j] 
	 			for j = 1 to Face_array.count do meshop.setMapFace mesh1 2 j Face_array[j] 	
					
				for j = 1 to Vert_Normal_array.count  do  meshop.setMapVert mesh1 1 j Vert_Normal_array[j] 
	 			for j = 1 to Face_array.count do meshop.setMapFace mesh1 1 j Face_array[j] 	
					
				mesh1.name = ((trimleft(Submesh_Material_Name)"mat_"))
				rotate mesh1 (angleaxis mesh_rotation [1,0,0])
				
				--flip UV`s, apply material/name, add checker map to the diffuse map.
				select mesh1
				modPanel.addModToSelection (UVW_Xform ()) ui:on

				mesh1.modifiers[#UVW_Xform].V_Flip = 1
				maxOps.CollapseNode mesh1 off	
				modPanel.addModToSelection (UVW_Xform ()) ui:on	
				mesh1.modifiers[#UVW_Xform].Map_Channel = 2
				mesh1.modifiers[#UVW_Xform].V_Flip = 1				

				maxOps.CollapseNode mesh1 off	
				mesh1.material = standardMaterial()
				mesh1.material.name = Submesh_Material_Name
				mesh1.material.showInViewport = on		
					----test
				
				TextureExt = ".png"  --"This determines what texturefile extension to look for"
			
				
				jaba = (getFilenamePath Mesh_Filename)
				jibi = (replace jaba (jaba.count - objectfullname.count-1) (objectfullname.count+2) "")					
				texturefiles = getFiles ((substitutestring jibi "\\" "/")+"/*"+TextureExt)
				if texturefiles.count == 0 do 
				(
						jtex1 = jibi +"/textures"	
						texturefiles = getFiles ((substitutestring jtex1 "\\" "/")+"/*"+TextureExt)
					)
-- 							texturefiles.count
				try
						(	
							for i = 1 to texturefiles.count do
								(
									if matchpattern texturefiles[i] pattern:("*"+(replace objectfullname (objectfullname.count-4) 5 "")+"_cm*")

										do 
									(
									_dFile = filenameFromPath(texturefiles[i])
									print  _dfile
									$.material.diffuseMap = bitmaptexture filename:texturefiles[i]	alphasource: 2
									$.material.diffuseMap.name = _dFile
										)
								)						
							for i = 1 to texturefiles.count do
								(
									if matchpattern texturefiles[i] pattern:("*"+(replace objectfullname (objectfullname.count-4) 5 "")+"_d*")

										do 
									(
									_dFile = filenameFromPath(texturefiles[i])
									print  _dfile	
									$.material.specularLevelMap = RGBTINT map1: (bitmaptexture filename:texturefiles[i] alphasource: 2) red: (color 0 0 0) blue:(color 0 0 0)
									$.material.specularLevelMap.name = _dFile
										)
								)	
								for i = 1 to texturefiles.count do
								(
									if matchpattern texturefiles[i] pattern:("*"+(replace objectfullname (objectfullname.count-4) 5 "")+"_n*")

										do 
									(
									_dFile = filenameFromPath(texturefiles[i])
									print  _dfile	
									$.material.BumpMap = normal_bump normal_map:(bitmaptexture filename:texturefiles[i] alphasource: 2)
									$.material.BumpMap.name = _dFile
										)
								)								
						)
				catch 
						(
							print "Textures not found"
						)
					if 	$.material.diffuseMap == undefined	do
					(
						$.material.diffuseMap = bitmaptexture filename:(tolower((getFilenamePath Texture_Path)+((trimleft(Submesh_Material_Name)"mat_")+("_d"))+(TextureExt)))
						$.material.diffuseMap.name = ((trimleft(Submesh_Material_Name)"mat_")+("_d"))
					)						
					if $.material.specularLevelMap == undefined do
					(
						$.material.specularLevelMap = RGBTINT map1: (bitmaptexture filename:(tolower((getFilenamePath Texture_Path)+((trimleft(Submesh_Material_Name)"mat_")+("_s"))+(TextureExt))) alphasource: 2)\
							red: (color 0 0 0) blue:(color 0 0 0)
							
						$.material.specularLevelMap.name = ((trimleft(Submesh_Material_Name)"mat_")+("_s"))
					)						
					if $.material.BumpMap == undefined do
					(
						$.material.BumpMap = normal_bump normal_map: (bitmaptexture filename:(tolower((getFilenamePath Texture_Path)+((trimleft(Submesh_Material_Name)"mat_")+("_n"))+(TextureExt))) alphasource: 2)
						$.material.BumpMap.name = ((trimleft(Submesh_Material_Name)"mat_")+("_n"))	
					)						
						
						
						
					-- 			--apply EditPoly modifier while selecting boneIndice dependent verts and detach vert selections to new scene objects.
						
				bool_for_query_box = false
				vertIndex_array = findItemIndexes Vert_Bone_Indices_array
						

				
				if objectType == 1 or objectType == 2 and bnarr != undefined do
					try
						(
							mesh1=$
							skinMod = skin()
							addModifier mesh1 skinMod

							for y in bone_Order_array do 
								(
										boneToAdd = bnarr[y+1]
										skinOps.addBone skinmod boneToAdd 0
									)

								vertex_count = getNumverts $	
									
								bi_arr=#()
								bw_arr=#()
								bnarr
								for dodo = 1 to submesh_vert_count do
									(
										bi_arr=#()
										bw_arr=#()
										for kilo = 1 to 4 do
											(
												bi = (Vert_Bone_Indices_array[dodo][kilo])+1
												bw = Vert_Blend_Weights_array[dodo][kilo]
												
												append bi_arr bi
												append bw_arr bw
											)
									vertex_count = getNumverts $
									--if objectType == 1(skinOps.replaceVertexWeights skinMod dodo bi_arr bw_arr)

									)	
								--reset arrays

								free face_array
								free Vert_Positions_array
								free Vert_Diffuse_array	
								completeredraw()
						)
						catch messagebox "bone_section_error"
						
						
						-- create new layer
						layer = LayerManager.newLayer()
						-- set layer's name
						layer.setname ((trimright(objectfullname)"_Mesh")+" "+(trimleft(Submesh_Material_Name)"mat_"))
						-- add nodes to layer from array
						layer.addnode mesh1
						LayerManager.editLayerByName ("Parts of  "+(trimleft(Submesh_Material_Name)"mat_"))
								
								
						PartOrder=#()
						for i in Vert_Bone_Indices_array do (appendifunique  PartOrder (i[1] as integer))	
 						--append global_parts_order_array PartOrder ---just for testing										
							
						select mesh1							
						convertto $ PolyMeshObject

						--this section is primarily meant for vehicle import while detaching parts  into separate objects
						parts_array=#()									
						SubSetArray=#()
						deletebool=false
						ptsbool=false
							
							if objectType == 2  do 
								--if BoneIndexSameBool==true do
										if vertIndex_array.count >= 2 then
											(
												if ptsbool==false then
													(
														if queryBox (("  Parts detected in       ")+(trimleft(Submesh_Material_Name)"mat_")+("       , separate the parts?"))  then
															(																											
																ptsbool=true	
																if queryBox (("Delete original mesh?   ")+(Submesh_Material_Name)) then	
																	(
																		deletebool=true
																	)			
															)
													)
												if ptsbool==true	then
												(
													for g =1 to (vertIndex_array.count) do 
															(
																select mesh1
																polyop.detachVerts $ vertIndex_array[g] delete:false asNode:true	name:(Submesh_Material_Name+"_"+g as string)	-- node:$Part
																part= (getnodebyname (Submesh_Material_Name+"_"+g as string))								
																append  Parts_array Part
															)
															for i = 1 to parts_array.count do (parts_array[i].transform = Pnt_arr[PartOrder[i]+1].transform)
															if deletebool==true then 
																(
																	delete mesh1
																)
													
												)
													
											)
														
			)			
						
		) 
				 	 
			clearSelection()
			max zoomext sel
			("Position "+((ftell mFile)as string))
			ChannelInfo.closeDialog() 
		gc()
	fclose C_File
	fclose Mfile	

			
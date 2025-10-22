
	clearlistener();
	
	--openfile dialog
	fname = getOpenFileName \ 
		caption:"Import skeleton file" \
		types:"Skeleton data (*.txt)|*.txt" \
		historyCategory:"Skeleton data"
			f = openfile fname
			b = openfile fname
			m =  openfile fname
			fbn = fopen fname "rb"
	
	--initialize arrays		
	boneposFloats_array=#()
	hierarchy_array=#()
	bonenames_array=#()
	bone_array=#()
	bnarr=#()

	--set scale for floats	
	scaler =39
	
	--bone count has to be set manually for now
	bone_count = 211
	
	--read hierachy array
	skiptostring f "Hierarchy::array"
	skiptonextline f
	for i = 1 to bone_count do (h1	 = (trimLeft (readLine f)" member")
		append hierarchy_array h1)	

		
	--read bonenames and append them to the array
	skiptostring b "BoneNames::array"	
	skiptonextline b
	for k in hierarchy_array do
		(bn1	 = (trimLeft (readLine b)" member")
		append bonenames_array bn1)	


	--skip first array because it apears it has some invalid data
	skiptostring m "ModelPose::array"
		
	--function to get the matrix3
for i = 1 to bone_count do
	(
	
	BoneName = bonenames_array[i]
	skiptostring m "member::LinearTransform"
	skiptonextline m
	skiptonextline m
	--read floats from 3 lines under "right::Vec3"
	rw1xf = (trimLeft (readLine m) " xyz" )as float*scaler
	rw1yf = (trimLeft (readLine m) " xyz") as float*scaler
	rw1zf = (trimLeft (readLine m) " xyz") as float*scaler
	--read floats from 3 lines under "up::Vec3"
			skiptonextline m
	rw2xf = (trimLeft (readLine m) " xyz") as float*scaler
	rw2yf = (trimLeft (readLine m) " xyz") as float*scaler
	rw2zf = (trimLeft (readLine m) " xyz") as float*scaler
	--read floats from 3 lines under "forward::Vec3"
			skiptonextline m
	rw3xf = (trimLeft (readLine m) " xyz") as float*scaler
	rw3yf = (trimLeft (readLine m) " xyz") as float*scaler
	rw3zf = (trimLeft (readLine m) " xyz") as float*scaler
	--read floats from 3 lines under "trans::Vec3"
			skiptonextline m
	rw4xf = (trimLeft (readLine m) " xyz") as float*scaler
	rw4yf = (trimLeft (readLine m) " xyz") as float*scaler
	rw4zf = (trimLeft (readLine m) " xyz") as float*scaler
	
	row1 = point3 (rw1xf)(rw1yf)(rw1zf)
	row2 = point3 (rw2xf)(rw2yf)(rw2zf)
	row3 = point3 (rw3xf)(rw3yf)(rw3zf)
	row4 = point3 (rw4xf)(rw4yf)(rw4zf)

				if (getNodeByName BoneName) != undefined do 
				(
					append BNArr (getNodeByName BoneName)
				)
				
				if (getNodeByName BoneName) == undefined do 
					(
						BoneParent = hierarchy_array[i]
						BP_ID = BoneParent as integer +1
						newBone = bonesys.createbone	\
								  row4	\
								  (row4 + 0.01 * (normalize row1)) \
								  (normalize row3)
						newBone.name = bonenames_array[i]
						newBone.width  = 0.01
						newBone.height = 0.01
						--newBone.transform = inverse tfm
						newBone.setBoneEnable false 0
						newBone.wirecolor = white
						newbone.showlinks = true
						newBone.pos.controller      = TCB_position ()
						newBone.rotation.controller = TCB_rotation ()
										  
							if (BP_ID!=0) then newBone.parent = BNarr[BP_ID]		  
							append BNArr newBone
					)		
)
fclose m
gc()
fclose f
fclose b
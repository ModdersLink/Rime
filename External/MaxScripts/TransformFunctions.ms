fn Vec3=(
			--__m128 = readbytes mfile 0x10 --simdvalue; // Offset = this + 0x0 Length = 0x10
	
			x= readfloat mfile		as float		--// Offset = this + 0x0 Length = 0x4
			y= readfloat mfile		as float		--// Offset = this + 0x4 Length = 0x4
			z= readfloat mfile		as float		--// Offset = this + 0x8 Length = 0x4
			pad= readfloat mfile	as float		--// Offset = this + 0xC Length = 0x4
			--_float=readbytes mfile 0x10	--// Offset = this + 0x0 Length = 0x10
			return [x,-z,y,pad]
		)




fn LinearTransform =(						
						left	=	Vec3()  --// Offset = this + 0x0 Length = 0x10
						up		=	Vec3()  --// Offset = this + 0x10 Length = 0x10
						forward	=	Vec3()  --// Offset = this + 0x20 Length = 0x10
						trans	=	Vec3() 	--// Offset = this + 0x30 Length = 0x10
					return #(left,up,forward,trans)
					)	

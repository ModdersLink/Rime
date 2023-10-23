#include <windows.h>

#include <stdio.h>

// Frostbite BuildInfo class.
// NOTE: This could possibly change for newer iterations of the engine.
// NOTE: Uncomment the two lines below for the BFH: Beta 2

class BuildInfo
{
public:
	virtual const char* getBranchName() const;
	virtual const char* getLicenseeId() const;
	//virtual const char* getBranchName2() const; // BFH: Beta 2
	virtual int getChangelist() const;
	virtual int getFrostbiteChangelist() const;
	virtual const char* getFrostbiteRelease() const;
	virtual const char* getUsername() const;
	virtual const char* getBuildTime() const;
	virtual const char* getBuildDate() const;
	virtual const char* getBuildIsoDate() const;
	//virtual int getUnknown() const;
};

typedef BuildInfo* (*getBuildInfo_t)();

// Proxy functions.

BuildInfo* GetBuildInfo(const char* p_Library)
{
	auto s_Library = LoadLibraryA(p_Library);

	if (!s_Library)
		return nullptr;

	auto s_Function = GetProcAddress(s_Library, "getBuildInfo");

	if (!s_Function)
		return nullptr;

	return ((getBuildInfo_t)s_Function)();
}

int ExceptionFilter(int p_Code, PEXCEPTION_POINTERS p_Ex)
{
	return EXCEPTION_EXECUTE_HANDLER;
}

int main(int argc, char** argv)
{
	if (argc != 2)
	{
		printf("Usage: BuildInfoProxy.exe <build info library>\n");
		return 1;
	}

	const char* s_LibraryPath = argv[1];

	auto s_BuildInfo = GetBuildInfo(s_LibraryPath);

	if (!s_BuildInfo)
	{
		printf("0\n");
		return 0;
	}

	auto s_OldBuild = true;

	__try
	{
		if (s_BuildInfo->getBuildDate() != nullptr)
			s_OldBuild = false;
	}
	__except (ExceptionFilter(GetExceptionCode(), GetExceptionInformation()))
	{
		s_OldBuild = true;
	}

	if (s_OldBuild)
		printf("7\n");
	else
		printf("9\n");

	// TODO: Fix this for Havana; it crashes. (see above note -kiwi)
	printf("%s\n", s_BuildInfo->getBranchName());
	printf("%s\n", s_BuildInfo->getLicenseeId());
	printf("%d\n", s_BuildInfo->getChangelist());
	printf("%d\n", s_BuildInfo->getFrostbiteChangelist());
	printf("%s\n", s_BuildInfo->getFrostbiteRelease());
	printf("%s\n", s_BuildInfo->getUsername());
	printf("%s\n", s_BuildInfo->getBuildTime());

	if (!s_OldBuild)
	{
		printf("%s\n", s_BuildInfo->getBuildDate());
		printf("%s\n", s_BuildInfo->getBuildIsoDate());
	}

	return 0;
}
//
//  main.m
//  PharmacyMenu
//

#import <GXUIApplication/GXUIApplication.h>
#import "PharmacyMenu-Swift.h"

#ifndef DEBUG
#import <dlfcn.h>
#import <sys/types.h>
typedef int (*ptrace_ptr_t)(int _request, pid_t _pid, caddr_t _addr, int _data);
#ifndef PT_DENY_ATTACH
#define PT_DENY_ATTACH 31
#endif
#endif

int main(int argc, char * argv[]) {
#ifndef DEBUG
	void* handle = dlopen(0, RTLD_GLOBAL | RTLD_NOW);
	ptrace_ptr_t ptrace_ptr = dlsym(handle, "ptrace");
	ptrace_ptr(PT_DENY_ATTACH, 0, 0, 0);
	dlclose(handle);
#endif
	@autoreleasepool {
		return UIApplicationMain(argc, argv, NSStringFromClass([GXUIApplication class]), NSStringFromClass([GXAppDelegate class]));
	}
}
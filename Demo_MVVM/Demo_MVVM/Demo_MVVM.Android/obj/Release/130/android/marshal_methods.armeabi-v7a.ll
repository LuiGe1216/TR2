; ModuleID = 'obj\Release\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Release\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [114 x i32] [
	i32 34715100, ; 0: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 46
	i32 57263871, ; 1: Xamarin.Forms.Core.dll => 0x369c6ff => 39
	i32 182336117, ; 2: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 36
	i32 318968648, ; 3: Xamarin.AndroidX.Activity.dll => 0x13031348 => 20
	i32 321597661, ; 4: System.Numerics => 0x132b30dd => 17
	i32 342366114, ; 5: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 30
	i32 347068432, ; 6: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 11
	i32 442521989, ; 7: Xamarin.Essentials => 0x1a605985 => 38
	i32 450948140, ; 8: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 28
	i32 465846621, ; 9: mscorlib => 0x1bc4415d => 6
	i32 469710990, ; 10: System.dll => 0x1bff388e => 15
	i32 546445716, ; 11: Demo_MVVM.Android.dll => 0x20921994 => 0
	i32 627609679, ; 12: Xamarin.AndroidX.CustomView => 0x2568904f => 26
	i32 700284507, ; 13: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 51
	i32 748832960, ; 14: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 9
	i32 809851609, ; 15: System.Drawing.Common.dll => 0x30455ad9 => 55
	i32 902159924, ; 16: Rg.Plugins.Popup => 0x35c5de34 => 7
	i32 928116545, ; 17: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 46
	i32 967690846, ; 18: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 30
	i32 974778368, ; 19: FormsViewGroup.dll => 0x3a19f000 => 3
	i32 1012816738, ; 20: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 35
	i32 1035644815, ; 21: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 22
	i32 1042160112, ; 22: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 43
	i32 1052210849, ; 23: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 32
	i32 1084122840, ; 24: Xamarin.Kotlin.StdLib => 0x409e66d8 => 53
	i32 1098259244, ; 25: System => 0x41761b2c => 15
	i32 1292207520, ; 26: SQLitePCLRaw.core.dll => 0x4d0585a0 => 10
	i32 1293217323, ; 27: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 27
	i32 1354490624, ; 28: Xamarin.Forms.GoogleMaps.dll => 0x50bbe300 => 41
	i32 1365406463, ; 29: System.ServiceModel.Internals.dll => 0x516272ff => 54
	i32 1371845985, ; 30: Xamarin.Forms.GoogleMaps.Android => 0x51c4b561 => 40
	i32 1376866003, ; 31: Xamarin.AndroidX.SavedState => 0x52114ed3 => 35
	i32 1406073936, ; 32: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 24
	i32 1411638395, ; 33: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 18
	i32 1460219004, ; 34: Xamarin.Forms.Xaml => 0x57092c7c => 44
	i32 1469204771, ; 35: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 21
	i32 1592978981, ; 36: System.Runtime.Serialization.dll => 0x5ef2ee25 => 1
	i32 1622152042, ; 37: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 33
	i32 1639515021, ; 38: System.Net.Http.dll => 0x61b9038d => 16
	i32 1658251792, ; 39: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 45
	i32 1698840827, ; 40: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 52
	i32 1711441057, ; 41: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 11
	i32 1729485958, ; 42: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 23
	i32 1766324549, ; 43: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 36
	i32 1776026572, ; 44: System.Core.dll => 0x69dc03cc => 14
	i32 1788241197, ; 45: Xamarin.AndroidX.Fragment => 0x6a96652d => 28
	i32 1808609942, ; 46: Xamarin.AndroidX.Loader => 0x6bcd3296 => 33
	i32 1813058853, ; 47: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 53
	i32 1813201214, ; 48: Xamarin.Google.Android.Material => 0x6c13413e => 45
	i32 1867746548, ; 49: Xamarin.Essentials.dll => 0x6f538cf4 => 38
	i32 1878053835, ; 50: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 44
	i32 1908813208, ; 51: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 48
	i32 1983156543, ; 52: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 52
	i32 2011961780, ; 53: System.Buffers.dll => 0x77ec19b4 => 13
	i32 2019465201, ; 54: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 32
	i32 2055257422, ; 55: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 31
	i32 2085496422, ; 56: Demo_MVVM.Android => 0x7c4e2666 => 0
	i32 2097448633, ; 57: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 29
	i32 2103459038, ; 58: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 12
	i32 2126786730, ; 59: Xamarin.Forms.Platform.Android => 0x7ec430aa => 42
	i32 2129483829, ; 60: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 47
	i32 2201231467, ; 61: System.Net.Http => 0x8334206b => 16
	i32 2279755925, ; 62: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 34
	i32 2445024337, ; 63: Xamarin.Forms.GoogleMaps.Android.dll => 0x91bc1c51 => 40
	i32 2465273461, ; 64: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 9
	i32 2475788418, ; 65: Java.Interop.dll => 0x93918882 => 4
	i32 2732626843, ; 66: Xamarin.AndroidX.Activity => 0xa2e0939b => 20
	i32 2737747696, ; 67: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 21
	i32 2766581644, ; 68: Xamarin.Forms.Core => 0xa4e6af8c => 39
	i32 2770495804, ; 69: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 51
	i32 2778768386, ; 70: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 37
	i32 2810250172, ; 71: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 24
	i32 2819470561, ; 72: System.Xml.dll => 0xa80db4e1 => 19
	i32 2847418871, ; 73: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 47
	i32 2853208004, ; 74: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 37
	i32 2861816565, ; 75: Rg.Plugins.Popup.dll => 0xaa93daf5 => 7
	i32 2905242038, ; 76: mscorlib.dll => 0xad2a79b6 => 6
	i32 2978675010, ; 77: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 27
	i32 3017076677, ; 78: Xamarin.GooglePlayServices.Maps => 0xb3d4efc5 => 49
	i32 3044182254, ; 79: FormsViewGroup => 0xb57288ee => 3
	i32 3058099980, ; 80: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 50
	i32 3111772706, ; 81: System.Runtime.Serialization => 0xb979e222 => 1
	i32 3184185322, ; 82: Demo_MVVM.dll => 0xbdcacfea => 2
	i32 3230466174, ; 83: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 48
	i32 3247949154, ; 84: Mono.Security => 0xc197c562 => 56
	i32 3258312781, ; 85: Xamarin.AndroidX.CardView => 0xc235e84d => 23
	i32 3286872994, ; 86: SQLite-net.dll => 0xc3e9b3a2 => 8
	i32 3317135071, ; 87: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 26
	i32 3353484488, ; 88: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 29
	i32 3360279109, ; 89: SQLitePCLRaw.core => 0xc849ca45 => 10
	i32 3362522851, ; 90: Xamarin.AndroidX.Core => 0xc86c06e3 => 25
	i32 3366347497, ; 91: Java.Interop => 0xc8a662e9 => 4
	i32 3374999561, ; 92: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 34
	i32 3395150330, ; 93: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 18
	i32 3404865022, ; 94: System.ServiceModel.Internals => 0xcaf21dfe => 54
	i32 3429136800, ; 95: System.Xml => 0xcc6479a0 => 19
	i32 3459516321, ; 96: Xamarin.Forms.GoogleMaps => 0xce3407a1 => 41
	i32 3476120550, ; 97: Mono.Android => 0xcf3163e6 => 5
	i32 3536029504, ; 98: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 42
	i32 3632359727, ; 99: Xamarin.Forms.Platform => 0xd881692f => 43
	i32 3641597786, ; 100: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 31
	i32 3672681054, ; 101: Mono.Android.dll => 0xdae8aa5e => 5
	i32 3680467114, ; 102: Demo_MVVM => 0xdb5f78aa => 2
	i32 3689375977, ; 103: System.Drawing.Common => 0xdbe768e9 => 55
	i32 3754567612, ; 104: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 12
	i32 3829621856, ; 105: System.Numerics.dll => 0xe4436460 => 17
	i32 3876362041, ; 106: SQLite-net => 0xe70c9739 => 8
	i32 3896760992, ; 107: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 25
	i32 3955647286, ; 108: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 22
	i32 3970018735, ; 109: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 50
	i32 4105002889, ; 110: Mono.Security.dll => 0xf4ad5f89 => 56
	i32 4151237749, ; 111: System.Core => 0xf76edc75 => 14
	i32 4260525087, ; 112: System.Buffers => 0xfdf2741f => 13
	i32 4278134329 ; 113: Xamarin.GooglePlayServices.Maps.dll => 0xfeff2639 => 49
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [114 x i32] [
	i32 46, i32 39, i32 36, i32 20, i32 17, i32 30, i32 11, i32 38, ; 0..7
	i32 28, i32 6, i32 15, i32 0, i32 26, i32 51, i32 9, i32 55, ; 8..15
	i32 7, i32 46, i32 30, i32 3, i32 35, i32 22, i32 43, i32 32, ; 16..23
	i32 53, i32 15, i32 10, i32 27, i32 41, i32 54, i32 40, i32 35, ; 24..31
	i32 24, i32 18, i32 44, i32 21, i32 1, i32 33, i32 16, i32 45, ; 32..39
	i32 52, i32 11, i32 23, i32 36, i32 14, i32 28, i32 33, i32 53, ; 40..47
	i32 45, i32 38, i32 44, i32 48, i32 52, i32 13, i32 32, i32 31, ; 48..55
	i32 0, i32 29, i32 12, i32 42, i32 47, i32 16, i32 34, i32 40, ; 56..63
	i32 9, i32 4, i32 20, i32 21, i32 39, i32 51, i32 37, i32 24, ; 64..71
	i32 19, i32 47, i32 37, i32 7, i32 6, i32 27, i32 49, i32 3, ; 72..79
	i32 50, i32 1, i32 2, i32 48, i32 56, i32 23, i32 8, i32 26, ; 80..87
	i32 29, i32 10, i32 25, i32 4, i32 34, i32 18, i32 54, i32 19, ; 88..95
	i32 41, i32 5, i32 42, i32 43, i32 31, i32 5, i32 2, i32 55, ; 96..103
	i32 12, i32 17, i32 8, i32 25, i32 22, i32 50, i32 56, i32 14, ; 104..111
	i32 13, i32 49 ; 112..113
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}

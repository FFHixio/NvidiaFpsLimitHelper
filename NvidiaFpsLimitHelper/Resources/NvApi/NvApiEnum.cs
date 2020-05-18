using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NvApi
{
    public partial class NvApiWrapper
    {
        public enum NVAPI_Id : uint
        {
            NvAPI_CreateDisplayFromUnAttachedDisplay = 0x63F9799E,
            NvAPI_D3D11_AliasMSAATexture2DAsNonMSAA = 0xF1C54FC9,
            NvAPI_D3D11_BeginUAVOverlap = 0x65B93CA8,
            NvAPI_D3D11_BeginUAVOverlapEx = 0xBA08208A,
            NvAPI_D3D11_CreateDevice = 0x6A16D3A0,
            NvAPI_D3D11_CreateDeviceAndSwapChain = 0xBB939EE5,
            NvAPI_D3D11_CreateRasterizerState = 0xDB8D28AF,
            NvAPI_D3D11_EndUAVOverlap = 0x2216A357,
            NvAPI_D3D11_IsNvShaderExtnOpCodeSupported = 0x5F68DA40,
            NvAPI_D3D11_SetDepthBoundsTest = 0x7AAF7A04,
            NvAPI_D3D11_SetNvShaderExtnSlot = 0x8E90BB9F,
            NvAPI_D3D1x_CreateSwapChain = 0x1BC21B66,
            NvAPI_D3D1x_DisableShaderDiskCache = 0xD0CBCA7D,
            NvAPI_D3D9_AliasSurfaceAsTexture = 0xE5CEAE41,
            NvAPI_D3D9_ClearRT = 0x332D3942,
            NvAPI_D3D9_CreateSwapChain = 0x1A131E09,
            NvAPI_D3D9_GetSurfaceHandle = 0x0F2DD3F2,
            NvAPI_D3D9_RegisterResource = 0xA064BDFC,
            NvAPI_D3D9_StretchRectEx = 0x22DE03AA,
            NvAPI_D3D9_UnregisterResource = 0xBB2B17AA,
            NvAPI_D3D9_VideoSetStereoInfo = 0xB852F4DB,
            NvAPI_D3D_BeginResourceRendering = 0x91123D6A,
            NvAPI_D3D_EndResourceRendering = 0x37E7191C,
            NvAPI_D3D_GetCurrentSLIState = 0x4B708B54,
            NvAPI_D3D_GetObjectHandleForResource = 0xFCEAC864,
            NvAPI_D3D_IsGSyncActive = 0xE942B0FF,
            NvAPI_D3D_IsGSyncCapable = 0x9C1EED78,
            NvAPI_D3D_SetFPSIndicatorState = 0xA776E8DB,
            NvAPI_D3D_SetResourceHint = 0x6C0ED98C,
            NvAPI_DisableHWCursor = 0xAB163097,
            NvAPI_Disp_ColorControl = 0x92F9D80D,
            NvAPI_DISP_DeleteCustomDisplay = 0x552E5B9B,
            NvAPI_DISP_EnumCustomDisplay = 0xA2072D59,
            NvAPI_DISP_GetAssociatedUnAttachedNvidiaDisplayHandle = 0xA70503B2,
            NvAPI_DISP_GetDisplayConfig = 0x11ABCCF8,
            NvAPI_DISP_GetDisplayIdByDisplayName = 0xAE457190,
            NvAPI_DISP_GetGDIPrimaryDisplayId = 0x1E9D8A31,
            NvAPI_DISP_GetMonitorCapabilities = 0x3B05C7E1,
            NvAPI_DISP_GetMonitorColorCapabilities = 0x6AE4CFB5,
            NvAPI_DISP_GetTiming = 0x175167E9,
            NvAPI_Disp_InfoFrameControl = 0x6067AF3F,
            NvAPI_DISP_RevertCustomDisplayTrial = 0xCBBD40F0,
            NvAPI_DISP_SaveCustomDisplay = 0x49882876,
            NvAPI_DISP_SetDisplayConfig = 0x5D8CF8DE,
            NvAPI_DISP_TryCustomDisplay = 0x1F7DB630,
            NvAPI_DRS_CreateApplication = 0x4347A9DE,
            NvAPI_DRS_CreateProfile = 0xCC176068,
            NvAPI_DRS_CreateSession = 0x0694D52E,
            NvAPI_DRS_DeleteApplication = 0x2C694BC6,
            NvAPI_DRS_DeleteApplicationEx = 0xC5EA85A1,
            NvAPI_DRS_DeleteProfile = 0x17093206,
            NvAPI_DRS_DeleteProfileSetting = 0xE4A26362,
            NvAPI_DRS_DestroySession = 0xDAD9CFF8,
            NvAPI_DRS_EnumApplications = 0x7FA2173A,
            NvAPI_DRS_EnumAvailableSettingIds = 0xF020614A,
            NvAPI_DRS_EnumAvailableSettingValues = 0x2EC39F90,
            NvAPI_DRS_EnumProfiles = 0xBC371EE0,
            NvAPI_DRS_EnumSettings = 0xAE3039DA,
            NvAPI_DRS_FindApplicationByName = 0xEEE566B2,
            NvAPI_DRS_FindProfileByName = 0x7E4A9A0B,
            NvAPI_DRS_GetApplicationInfo = 0xED1F8C69,
            NvAPI_DRS_GetBaseProfile = 0xDA8466A0,
            NvAPI_DRS_GetCurrentGlobalProfile = 0x617BFF9F,
            NvAPI_DRS_GetNumProfiles = 0x1DAE4FBC,
            NvAPI_DRS_GetProfileInfo = 0x61CD6FD6,
            NvAPI_DRS_GetSetting = 0x73BF8338,
            NvAPI_DRS_GetSettingIdFromName = 0xCB7309CD,
            NvAPI_DRS_GetSettingNameFromId = 0xD61CBE6E,
            NvAPI_DRS_LoadSettings = 0x375DBD6B,
            NvAPI_DRS_LoadSettingsFromFile = 0xD3EDE889,
            NvAPI_DRS_RestoreAllDefaults = 0x5927B094,
            NvAPI_DRS_RestoreProfileDefault = 0xFA5F6134,
            NvAPI_DRS_RestoreProfileDefaultSetting = 0x53F0381E,
            NvAPI_DRS_SaveSettings = 0xFCBC7E14,
            NvAPI_DRS_SaveSettingsToFile = 0x2BE25DF8,
            NvAPI_DRS_SetCurrentGlobalProfile = 0x1C89C5DF,
            NvAPI_DRS_SetProfileInfo = 0x16ABD3A9,
            NvAPI_DRS_SetSetting = 0x577DD202,
            NvAPI_EnableCurrentMosaicTopology = 0x74073CC9,
            NvAPI_EnableHWCursor = 0x2863148D,
            NvAPI_EnumLogicalGPUs = 0x48B3EA59,
            NvAPI_EnumNvidiaDisplayHandle = 0x9ABDD40D,
            NvAPI_EnumNvidiaUnAttachedDisplayHandle = 0x20DE9260,
            NvAPI_EnumPhysicalGPUs = 0xE5AC921F,
            NvAPI_EnumTCCPhysicalGPUs = 0xD9930B07,
            NvAPI_GetAssociatedDisplayOutputId = 0xD995937E,
            NvAPI_GetAssociatedNvidiaDisplayHandle = 0x35C29134,
            NvAPI_GetAssociatedNvidiaDisplayName = 0x22A78B05,
            NvAPI_GetCurrentMosaicTopology = 0xF60852BD,
            NvAPI_GetDisplayDriverVersion = 0xF951A4D1,
            NvAPI_GetDisplayPortInfo = 0xC64FF367,
            NvAPI_GetErrorMessage = 0x6C2D048C,
            NvAPI_GetHDMISupportInfo = 0x6AE16EC3,
            NvAPI_GetInterfaceVersionString = 0x01053FA5,
            NvAPI_GetLogicalGPUFromDisplay = 0xEE1370CF,
            NvAPI_GetLogicalGPUFromPhysicalGPU = 0xADD604D1,
            NvAPI_GetPhysicalGPUFromUnAttachedDisplay = 0x5018ED61,
            NvAPI_GetPhysicalGPUsFromDisplay = 0x34EF9506,
            NvAPI_GetPhysicalGPUsFromLogicalGPU = 0xAEA3FA32,
            NvAPI_GetSupportedMosaicTopologies = 0x410B5C25,
            NvAPI_GetSupportedViews = 0x66FB7FC0,
            NvAPI_GetUnAttachedAssociatedDisplayName = 0x4888D790,
            NvAPI_GetVBlankCounter = 0x67B5DB55,
            NvAPI_GetView = 0xD6B99D89,
            NvAPI_GetViewEx = 0xDBBC0AF4,
            NvAPI_GPU_GetActiveOutputs = 0xE3E89B6F,
            NvAPI_GPU_GetAGPAperture = 0x6E042794,
            NvAPI_GPU_GetAllClockFrequencies = 0xDCB616C3,
            NvAPI_GPU_GetAllDisplayIds = 0x785210A2,
            NvAPI_GPU_GetAllOutputs = 0x7D554F8E,
            NvAPI_GPU_GetBoardInfo = 0x22D54523,
            NvAPI_GPU_GetBusId = 0x1BE0B8E5,
            NvAPI_GPU_GetBusSlotId = 0x2A0A350F,
            NvAPI_GPU_GetBusType = 0x1BB18724,
            NvAPI_GPU_GetConnectedDisplayIds = 0x0078DBA2,
            NvAPI_GPU_GetConnectedOutputs = 0x1730BFC9,
            NvAPI_GPU_GetConnectedOutputsWithLidState = 0xCF8CAF39,
            NvAPI_GPU_GetConnectedSLIOutputs = 0x0680DE09,
            NvAPI_GPU_GetConnectedSLIOutputsWithLidState = 0x96043CC7,
            NvAPI_GPU_GetCurrentAGPRate = 0xC74925A0,
            NvAPI_GPU_GetCurrentPCIEDownstreamWidth = 0xD048C3B1,
            NvAPI_GPU_GetCurrentPstate = 0x927DA4F6,
            NvAPI_GPU_GetDynamicPstatesInfoEx = 0x60DED2ED,
            NvAPI_GPU_GetECCConfigurationInfo = 0x77A796F3,
            NvAPI_GPU_GetECCErrorInfo = 0xC71F85A6,
            NvAPI_GPU_GetECCStatusInfo = 0xCA1DDAF3,
            NvAPI_GPU_GetEDID = 0x37D32E69,
            NvAPI_GPU_GetFullName = 0xCEEE8E9F,
            NvAPI_GPU_GetGpuCoreCount = 0xC7026A87,
            NvAPI_GPU_GetGPUType = 0xC33BAEB1,
            NvAPI_GPU_GetHDCPSupportStatus = 0xF089EEF5,
            NvAPI_GPU_GetIllumination = 0x9A1B9365,
            NvAPI_GPU_GetIRQ = 0xE4715417,
            NvAPI_GPU_GetMemoryInfo = 0x07F9B368,
            NvAPI_GPU_GetOutputType = 0x40A505E4,
            NvAPI_GPU_GetPCIIdentifiers = 0x2DDFB66E,
            NvAPI_GPU_GetPerfDecreaseInfo = 0x7F7F4600,
            NvAPI_GPU_GetPhysicalFrameBufferSize = 0x46FBEB03,
            NvAPI_GPU_GetPstates20 = 0x6FF81213,
            NvAPI_GPU_GetPstatesInfoEx = 0x843C0256,
            NvAPI_GPU_GetScanoutCompositionParameter = 0x58FE51E6,
            NvAPI_GPU_GetScanoutConfiguration = 0x6A9F5B63,
            NvAPI_GPU_GetScanoutConfigurationEx = 0xE2E1E6F0,
            NvAPI_GPU_GetScanoutIntensityState = 0xE81CE836,
            NvAPI_GPU_GetScanoutWarpingState = 0x6F5435AF,
            NvAPI_GPU_GetSystemType = 0xBAAABFCC,
            NvAPI_GPU_GetTachReading = 0x5F608315,
            NvAPI_GPU_GetThermalSettings = 0xE3640A56,
            NvAPI_GPU_GetVbiosOEMRevision = 0x2D43FB31,
            NvAPI_GPU_GetVbiosRevision = 0xACC3DA0A,
            NvAPI_GPU_GetVbiosVersionString = 0xA561FD7D,
            NvAPI_GPU_GetVirtualFrameBufferSize = 0x5A04B644,
            NvAPI_GPU_QueryIlluminationSupport = 0xA629DA31,
            NvAPI_GPU_ResetECCErrorInfo = 0xC02EEC20,
            NvAPI_GPU_SetECCConfiguration = 0x1CF639D9,
            NvAPI_GPU_SetEDID = 0xE83D6456,
            NvAPI_GPU_SetIllumination = 0x0254A187,
            NvAPI_GPU_SetScanoutCompositionParameter = 0xF898247D,
            NvAPI_GPU_SetScanoutIntensity = 0xA57457A4,
            NvAPI_GPU_SetScanoutWarping = 0xB34BAB4F,
            NvAPI_GPU_ValidateOutputCombination = 0x34C9C2D4,
            NvAPI_GPU_WorkstationFeatureQuery = 0x004537DF,
            NvAPI_GPU_WorkstationFeatureSetup = 0x6C1F3FE4,
            NvAPI_GSync_AdjustSyncDelay = 0x2D11FF51,
            NvAPI_GSync_EnumSyncDevices = 0xD9639601,
            NvAPI_GSync_GetControlParameters = 0x16DE1C6A,
            NvAPI_GSync_GetStatusParameters = 0x70D404EC,
            NvAPI_GSync_GetSyncStatus = 0xF1F5B434,
            NvAPI_GSync_GetTopology = 0x4562BC38,
            NvAPI_GSync_QueryCapabilities = 0x44A3F1D1,
            NvAPI_GSync_SetControlParameters = 0x8BBFF88B,
            NvAPI_GSync_SetSyncStateSettings = 0x60ACDFDD,
            NvAPI_I2CRead = 0x2FDE12C5,
            NvAPI_I2CWrite = 0xE812EB07,
            NvAPI_Initialize = 0x0150E828,
            NvAPI_Mosaic_EnableCurrentTopo = 0x5F1AA66C,
            NvAPI_Mosaic_EnumDisplayGrids = 0xDF2887AF,
            NvAPI_Mosaic_EnumDisplayModes = 0x78DB97D7,
            NvAPI_Mosaic_GetCurrentTopo = 0xEC32944E,
            NvAPI_Mosaic_GetDisplayViewportsByResolution = 0xDC6DC8D3,
            NvAPI_Mosaic_GetOverlapLimits = 0x989685F0,
            NvAPI_Mosaic_GetSupportedTopoInfo = 0xFDB63C81,
            NvAPI_Mosaic_GetTopoGroup = 0xCB89381D,
            NvAPI_Mosaic_SetCurrentTopo = 0x9B542831,
            NvAPI_Mosaic_SetDisplayGrids = 0x4D959A89,
            NvAPI_Mosaic_ValidateDisplayGrids = 0xCF43903D,
            NvAPI_OGL_ExpertModeDefaultsGet = 0xAE921F12,
            NvAPI_OGL_ExpertModeDefaultsSet = 0xB47A657E,
            NvAPI_OGL_ExpertModeGet = 0x22ED9516,
            NvAPI_OGL_ExpertModeSet = 0x3805EF7A,
            NvAPI_SetCurrentMosaicTopology = 0xD54B8989,
            NvAPI_SetDisplayPort = 0xFA13E65A,
            NvAPI_SetRefreshRateOverride = 0x3092AC32,
            NvAPI_SetView = 0x0957D7B6,
            NvAPI_SetViewEx = 0x06B89E68,
            NvAPI_Stereo_Activate = 0xF6A1AD68,
            NvAPI_Stereo_CaptureJpegImage = 0x932CB140,
            NvAPI_Stereo_CapturePngImage = 0x8B7E99B5,
            NvAPI_Stereo_CreateConfigurationProfileRegistryKey = 0xBE7692EC,
            NvAPI_Stereo_CreateHandleFromIUnknown = 0xAC7E37F4,
            NvAPI_Stereo_Deactivate = 0x2D68DE96,
            NvAPI_Stereo_Debug_WasLastDrawStereoized = 0xED4416C5,
            NvAPI_Stereo_DecreaseConvergence = 0x4C87E317,
            NvAPI_Stereo_DecreaseSeparation = 0xDA044458,
            NvAPI_Stereo_DeleteConfigurationProfileRegistryKey = 0xF117B834,
            NvAPI_Stereo_DeleteConfigurationProfileValue = 0x49BCEECF,
            NvAPI_Stereo_DestroyHandle = 0x3A153134,
            NvAPI_Stereo_Disable = 0x2EC50C2B,
            NvAPI_Stereo_Enable = 0x239C4545,
            NvAPI_Stereo_GetConvergence = 0x4AB00934,
            NvAPI_Stereo_GetDefaultProfile = 0x624E21C2,
            NvAPI_Stereo_GetEyeSeparation = 0xCE653127,
            NvAPI_Stereo_GetFrustumAdjustMode = 0xE6839B43,
            NvAPI_Stereo_GetSeparation = 0x451F2134,
            NvAPI_Stereo_GetStereoSupport = 0x296C434D,
            NvAPI_Stereo_GetSurfaceCreationMode = 0x36F1C736,
            NvAPI_Stereo_IncreaseConvergence = 0xA17DAABE,
            NvAPI_Stereo_IncreaseSeparation = 0xC9A8ECEC,
            NvAPI_Stereo_InitActivation = 0xC7177702,
            NvAPI_Stereo_IsActivated = 0x1FB0BC30,
            NvAPI_Stereo_IsEnabled = 0x348FF8E1,
            NvAPI_Stereo_IsWindowedModeSupported = 0x40C8ED5E,
            NvAPI_Stereo_ReverseStereoBlitControl = 0x3CD58F89,
            NvAPI_Stereo_SetActiveEye = 0x96EEA9F8,
            NvAPI_Stereo_SetConfigurationProfileValue = 0x24409F48,
            NvAPI_Stereo_SetConvergence = 0x3DD6B54B,
            NvAPI_Stereo_SetDefaultProfile = 0x44F0ECD1,
            NvAPI_Stereo_SetDriverMode = 0x5E8F0BEC,
            NvAPI_Stereo_SetFrustumAdjustMode = 0x7BE27FA2,
            NvAPI_Stereo_SetNotificationMessage = 0x6B9B409E,
            NvAPI_Stereo_SetSeparation = 0x5C069FA3,
            NvAPI_Stereo_SetSurfaceCreationMode = 0xF5DCFCBA,
            NvAPI_Stereo_Trigger_Activation = 0x0D6C6CD2,
            NvAPI_SYS_GetChipSetInfo = 0x53DABBCA,
            NvAPI_SYS_GetDisplayIdFromGpuAndOutputId = 0x08F2BAB4,
            NvAPI_SYS_GetDriverAndBranchVersion = 0x2926AAAD,
            NvAPI_SYS_GetGpuAndOutputIdFromDisplayId = 0x112BA1A5,
            NvAPI_SYS_GetLidAndDockInfo = 0xCDA14D8A,
            NvAPI_SYS_GetPhysicalGpuFromDisplayId = 0x9EA74659,
            NvAPI_Unload = 0xD22BDD7E,
            NvAPI_VIO_Close = 0xD01BD237,
            NvAPI_VIO_EnumDataFormats = 0x221FA8E8,
            NvAPI_VIO_EnumDevices = 0xFD7C5557,
            NvAPI_VIO_EnumSignalFormats = 0xEAD72FE4,
            NvAPI_VIO_GetCapabilities = 0x1DC91303,
            NvAPI_VIO_GetConfig = 0xD34A789B,
            NvAPI_VIO_GetCSC = 0x7B0D72A3,
            NvAPI_VIO_GetGamma = 0x51D53D06,
            NvAPI_VIO_GetPCIInfo = 0xB981D935,
            NvAPI_VIO_GetSyncDelay = 0x462214A9,
            NvAPI_VIO_IsFrameLockModeCompatible = 0x7BF0A94D,
            NvAPI_VIO_IsRunning = 0x96BD040E,
            NvAPI_VIO_Open = 0x44EE4841,
            NvAPI_VIO_QueryTopology = 0x869534E2,
            NvAPI_VIO_SetConfig = 0x0E4EEC07,
            NvAPI_VIO_SetCSC = 0xA1EC8D74,
            NvAPI_VIO_SetGamma = 0x964BF452,
            NvAPI_VIO_SetSyncDelay = 0x2697A8D1,
            NvAPI_VIO_Start = 0xCDE8E1A3,
            NvAPI_VIO_Status = 0x0E6CE4F1,
            NvAPI_VIO_Stop = 0x6BA2A5D6,
            NvAPI_VIO_SyncFormatDetect = 0x118D48A3
        }

        public enum NVAPI_Status : int
        {
            NVAPI_OK = 0,
            NVAPI_ERROR = -1,
            NVAPI_LIBRARY_NOT_FOUND = -2,
            NVAPI_NO_IMPLEMENTATION = -3,
            NVAPI_API_NOT_INITIALIZED = -4,
            NVAPI_INVALID_ARGUMENT = -5,
            NVAPI_NVIDIA_DEVICE_NOT_FOUND = -6,
            NVAPI_END_ENUMERATION = -7,
            NVAPI_INVALID_HANDLE = -8,
            NVAPI_INCOMPATIBLE_STRUCT_VERSION = -9,
            NVAPI_HANDLE_INVALIDATED = -10,
            NVAPI_OPENGL_CONTEXT_NOT_CURRENT = -11,
            NVAPI_INVALID_POINTER = -14,
            NVAPI_NO_GL_EXPERT = -12,
            NVAPI_INSTRUMENTATION_DISABLED = -13,
            NVAPI_NO_GL_NSIGHT = -15,
            NVAPI_EXPECTED_LOGICAL_GPU_HANDLE = -100,
            NVAPI_EXPECTED_PHYSICAL_GPU_HANDLE = -101,
            NVAPI_EXPECTED_DISPLAY_HANDLE = -102,
            NVAPI_INVALID_COMBINATION = -103,
            NVAPI_NOT_SUPPORTED = -104,
            NVAPI_PORTID_NOT_FOUND = -105,
            NVAPI_EXPECTED_UNATTACHED_DISPLAY_HANDLE = -106,
            NVAPI_INVALID_PERF_LEVEL = -107,
            NVAPI_DEVICE_BUSY = -108,
            NVAPI_NV_PERSIST_FILE_NOT_FOUND = -109,
            NVAPI_PERSIST_DATA_NOT_FOUND = -110,
            NVAPI_EXPECTED_TV_DISPLAY = -111,
            NVAPI_EXPECTED_TV_DISPLAY_ON_DCONNECTOR = -112,
            NVAPI_NO_ACTIVE_SLI_TOPOLOGY = -113,
            NVAPI_SLI_RENDERING_MODE_NOTALLOWED = -114,
            NVAPI_EXPECTED_DIGITAL_FLAT_PANEL = -115,
            NVAPI_ARGUMENT_EXCEED_MAX_SIZE = -116,
            NVAPI_DEVICE_SWITCHING_NOT_ALLOWED = -117,
            NVAPI_TESTING_CLOCKS_NOT_SUPPORTED = -118,
            NVAPI_UNKNOWN_UNDERSCAN_CONFIG = -119,
            NVAPI_TIMEOUT_RECONFIGURING_GPU_TOPO = -120,
            NVAPI_DATA_NOT_FOUND = -121,
            NVAPI_EXPECTED_ANALOG_DISPLAY = -122,
            NVAPI_NO_VIDLINK = -123,
            NVAPI_REQUIRES_REBOOT = -124,
            NVAPI_INVALID_HYBRID_MODE = -125,
            NVAPI_MIXED_TARGET_TYPES = -126,
            NVAPI_SYSWOW64_NOT_SUPPORTED = -127,
            NVAPI_IMPLICIT_SET_GPU_TOPOLOGY_CHANGE_NOT_ALLOWED = -128,
            NVAPI_REQUEST_USER_TO_CLOSE_NON_MIGRATABLE_APPS = -129,
            NVAPI_OUT_OF_MEMORY = -130,
            NVAPI_WAS_STILL_DRAWING = -131,
            NVAPI_FILE_NOT_FOUND = -132,
            NVAPI_TOO_MANY_UNIQUE_STATE_OBJECTS = -133,
            NVAPI_INVALID_CALL = -134,
            NVAPI_D3D10_1_LIBRARY_NOT_FOUND = -135,
            NVAPI_FUNCTION_NOT_FOUND = -136,
            NVAPI_INVALID_USER_PRIVILEGE = -137,
            NVAPI_EXPECTED_NON_PRIMARY_DISPLAY_HANDLE = -138,
            NVAPI_EXPECTED_COMPUTE_GPU_HANDLE = -139,
            NVAPI_STEREO_NOT_INITIALIZED = -140,
            NVAPI_STEREO_REGISTRY_ACCESS_FAILED = -141,
            NVAPI_STEREO_REGISTRY_PROFILE_TYPE_NOT_SUPPORTED = -142,
            NVAPI_STEREO_REGISTRY_VALUE_NOT_SUPPORTED = -143,
            NVAPI_STEREO_NOT_ENABLED = -144,
            NVAPI_STEREO_NOT_TURNED_ON = -145,
            NVAPI_STEREO_INVALID_DEVICE_INTERFACE = -146,
            NVAPI_STEREO_PARAMETER_OUT_OF_RANGE = -147,
            NVAPI_STEREO_FRUSTUM_ADJUST_MODE_NOT_SUPPORTED = -148,
            NVAPI_TOPO_NOT_POSSIBLE = -149,
            NVAPI_MODE_CHANGE_FAILED = -150,
            NVAPI_D3D11_LIBRARY_NOT_FOUND = -151,
            NVAPI_INVALID_ADDRESS = -152,
            NVAPI_STRING_TOO_SMALL = -153,
            NVAPI_MATCHING_DEVICE_NOT_FOUND = -154,
            NVAPI_DRIVER_RUNNING = -155,
            NVAPI_DRIVER_NOTRUNNING = -156,
            NVAPI_ERROR_DRIVER_RELOAD_REQUIRED = -157,
            NVAPI_SET_NOT_ALLOWED = -158,
            NVAPI_ADVANCED_DISPLAY_TOPOLOGY_REQUIRED = -159,
            NVAPI_SETTING_NOT_FOUND = -160,
            NVAPI_SETTING_SIZE_TOO_LARGE = -161,
            NVAPI_TOO_MANY_SETTINGS_IN_PROFILE = -162,
            NVAPI_PROFILE_NOT_FOUND = -163,
            NVAPI_PROFILE_NAME_IN_USE = -164,
            NVAPI_PROFILE_NAME_EMPTY = -165,
            NVAPI_EXECUTABLE_NOT_FOUND = -166,
            NVAPI_EXECUTABLE_ALREADY_IN_USE = -167,
            NVAPI_DATATYPE_MISMATCH = -168,
            NVAPI_PROFILE_REMOVED = -169,
            NVAPI_UNREGISTERED_RESOURCE = -170,
            NVAPI_ID_OUT_OF_RANGE = -171,
            NVAPI_DISPLAYCONFIG_VALIDATION_FAILED = -172,
            NVAPI_DPMST_CHANGED = -173,
            NVAPI_INSUFFICIENT_BUFFER = -174,
            NVAPI_ACCESS_DENIED = -175,
            NVAPI_MOSAIC_NOT_ACTIVE = -176,
            NVAPI_SHARE_RESOURCE_RELOCATED = -177,
            NVAPI_REQUEST_USER_TO_DISABLE_DWM = -178,
            NVAPI_D3D_DEVICE_LOST = -179,
            NVAPI_INVALID_CONFIGURATION = -180,
            NVAPI_STEREO_HANDSHAKE_NOT_DONE = -181,
            NVAPI_EXECUTABLE_PATH_IS_AMBIGUOUS = -182,
            NVAPI_DEFAULT_STEREO_PROFILE_IS_NOT_DEFINED = -183,
            NVAPI_DEFAULT_STEREO_PROFILE_DOES_NOT_EXIST = -184,
            NVAPI_CLUSTER_ALREADY_EXISTS = -185,
            NVAPI_DPMST_DISPLAY_ID_EXPECTED = -186,
            NVAPI_INVALID_DISPLAY_ID = -187,
            NVAPI_STREAM_IS_OUT_OF_SYNC = -188,
            NVAPI_INCOMPATIBLE_AUDIO_DRIVER = -189,
            NVAPI_VALUE_ALREADY_SET = -190,
            NVAPI_TIMEOUT = -191,
            NVAPI_GPU_WORKSTATION_FEATURE_INCOMPLETE = -192,
            NVAPI_STEREO_INIT_ACTIVATION_NOT_DONE = -193,
            NVAPI_SYNC_NOT_ACTIVE = -194,
            NVAPI_SYNC_MASTER_NOT_FOUND = -195,
            NVAPI_INVALID_SYNC_TOPOLOGY = -196,
            NVAPI_ECID_SIGN_ALGO_UNSUPPORTED = -197,
            NVAPI_ECID_KEY_VERIFICATION_FAILED = -198,
            NVAPI_FIRMWARE_OUT_OF_DATE = -199,
            NVAPI_FIRMWARE_REVISION_NOT_SUPPORTED = -200,
            NVAPI_LICENSE_CALLER_AUTHENTICATION_FAILED = -201,
            NVAPI_D3D_DEVICE_NOT_REGISTERED = -202,
            NVAPI_RESOURCE_NOT_ACQUIRED = -203,
            NVAPI_TIMING_NOT_SUPPORTED = -204,
            NVAPI_HDCP_ENCRYPTION_FAILED = -205,
            NVAPI_PCLK_LIMITATION_FAILED = -206,
            NVAPI_NO_CONNECTOR_FOUND = -207,
            NVAPI_HDCP_DISABLED = -208,
            NVAPI_API_IN_USE = -209,
            NVAPI_NVIDIA_DISPLAY_NOT_FOUND = -210,
            NVAPI_PRIV_SEC_VIOLATION = -211,
            NVAPI_INCORRECT_VENDOR = -212,
            NVAPI_DISPLAY_IN_USE = -213,
            NVAPI_UNSUPPORTED_CONFIG_NON_HDCP_HMD = -214,
            NVAPI_MAX_DISPLAY_LIMIT_REACHED = -215,
            NVAPI_INVALID_DIRECT_MODE_DISPLAY = -216,
            NVAPI_GPU_IN_DEBUG_MODE = -217,
            NVAPI_D3D_CONTEXT_NOT_FOUND = -218,
            NVAPI_STEREO_VERSION_MISMATCH = -219,
            NVAPI_GPU_NOT_POWERED = -220,
            NVAPI_ERROR_DRIVER_RELOAD_IN_PROGRESS = -221,
            NVAPI_WAIT_FOR_HW_RESOURCE = -222,
            NVAPI_REQUIRE_FURTHER_HDCP_ACTION = -223,
            NVAPI_DISPLAY_MUX_TRANSITION_FAILED = -224
        }

        public enum NVDRS_SETTING_TYPE : int
        {
            NVDRS_DWORD_TYPE,
            NVDRS_BINARY_TYPE,
            NVDRS_STRING_TYPE,
            NVDRS_WSTRING_TYPE
        }

        public enum NVDRS_SETTING_LOCATION : int
        {
            NVDRS_CURRENT_PROFILE_LOCATION,
            NVDRS_GLOBAL_PROFILE_LOCATION,
            NVDRS_BASE_PROFILE_LOCATION,
            NVDRS_DEFAULT_PROFILE_LOCATION
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Unicode, Size = (int)NVAPI_BINARY_DATA_MAX)]
        public struct NVDRS_SETTING_UNION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)NVAPI_BINARY_DATA_MAX)]
            public byte[] rawData;

            public byte[] binaryValue
            {
                get
                {
                    uint length = BitConverter.ToUInt32(rawData, 0);
                    byte[] tmpData = new byte[length];
                    Buffer.BlockCopy(rawData, 4, tmpData, 0, (int)length);
                    return tmpData;
                }
                set
                {
                    rawData = new byte[(int)NVAPI_BINARY_DATA_MAX];
                    if (value != null)
                    {
                        Buffer.BlockCopy(BitConverter.GetBytes(value.Length), 0, rawData, 0, 4);
                        Buffer.BlockCopy(value, 0, rawData, 4, value.Length);
                    }
                }
            }

            public uint dwordValue
            {
                get
                {
                    return BitConverter.ToUInt32(rawData, 0);
                }
                set
                {
                    rawData = new byte[(int)NVAPI_BINARY_DATA_MAX];
                    Buffer.BlockCopy(BitConverter.GetBytes(value), 0, rawData, 0, 4);
                }
            }

            public string unicodeStringValue
            {
                get
                {
                    return Encoding.Unicode.GetString(rawData).TrimEnd((char)0);
                }
                set
                {
                    rawData = new byte[(int)NVAPI_BINARY_DATA_MAX];
                    byte[] bytesRaw = Encoding.Unicode.GetBytes(value);
                    Buffer.BlockCopy(bytesRaw, 0, rawData, 0, bytesRaw.Length);
                }
            }

            public string ansiStringValue
            {
                get
                {
                    return Encoding.Default.GetString(rawData).TrimEnd((char)0);
                }
                set
                {
                    rawData = new byte[(int)NVAPI_BINARY_DATA_MAX];
                    byte[] bytesRaw = Encoding.Default.GetBytes(value);
                    Buffer.BlockCopy(bytesRaw, 0, rawData, 0, bytesRaw.Length);
                }
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Unicode)]
        public struct NVDRS_SETTING_V1
        {
            public uint version;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = (int)NVAPI_UNICODE_STRING_MAX)]
            public string settingName;
            public uint settingId;
            public NVDRS_SETTING_TYPE settingType;
            public NVDRS_SETTING_LOCATION settingLocation;
            public uint isCurrentPredefined;
            public uint isPredefinedValid;
            public NVDRS_SETTING_UNION predefinedValue;
            public NVDRS_SETTING_UNION currentValue;
        }
    }
}
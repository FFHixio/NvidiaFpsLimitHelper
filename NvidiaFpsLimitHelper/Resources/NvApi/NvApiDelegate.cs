using System;
using System.Runtime.InteropServices;

namespace NvApi
{
    public partial class NvApiWrapper
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NVAPI_Status NvAPI_InitializeDelegate();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NVAPI_Status NvAPI_DRS_CreateSessionDelegate(ref IntPtr hSession);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NVAPI_Status NvAPI_DRS_DestroySessionDelegate(IntPtr hSession);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NVAPI_Status NvAPI_DRS_GetBaseProfileDelegate(IntPtr hSession, ref IntPtr hProfile);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NVAPI_Status NvAPI_DRS_LoadSettingsDelegate(IntPtr hSession);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NVAPI_Status NvAPI_DRS_SaveSettingsDelegate(IntPtr hSession);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NVAPI_Status NvAPI_DRS_SetSettingDelegate(IntPtr hSession, IntPtr hProfile, ref NVDRS_SETTING_V1 hSetting);
    }
}
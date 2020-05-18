using NvApi.DriverSettings;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace NvApi
{
    public partial class NvApiWrapper
    {
        [DllImport("nvapi64.dll", EntryPoint = "nvapi_QueryInterface", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr NvApiQueryInterface64(uint id);

        [DllImport("nvapi.dll", EntryPoint = "nvapi_QueryInterface", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr NvApiQueryInterface32(uint id);

        //Get delegate that belongs to the api id
        private static T GetApiIdDelegate<T>(NVAPI_Id apiId) where T : class
        {
            try
            {
                IntPtr intPtrApiQuery = IntPtr.Zero;
                if (IntPtr.Size > 4)
                {
                    intPtrApiQuery = NvApiQueryInterface64((uint)apiId);
                }
                else
                {
                    intPtrApiQuery = NvApiQueryInterface32((uint)apiId);
                }

                if (intPtrApiQuery != IntPtr.Zero)
                {
                    return Marshal.GetDelegateForFunctionPointer(intPtrApiQuery, typeof(T)) as T;
                }
            }
            catch { }
            return null;
        }

        //Update the maximum frame rate setting
        public static bool UpdateMaxFrameRate(int maxFrameRate)
        {
            try
            {
                //Session and profile variables
                IntPtr hSession = IntPtr.Zero;
                IntPtr hProfile = IntPtr.Zero;

                //Initialize api
                NVAPI_Status nvAPI_Initialize = GetApiIdDelegate<NvAPI_InitializeDelegate>(NVAPI_Id.NvAPI_Initialize)();
                if (nvAPI_Initialize != NVAPI_Status.NVAPI_OK)
                {
                    Debug.WriteLine("Failed to initialize the nvidia api.");
                    return false;
                }

                //Create session
                NVAPI_Status nvAPI_DRS_CreateSessionDelegate = GetApiIdDelegate<NvAPI_DRS_CreateSessionDelegate>(NVAPI_Id.NvAPI_DRS_CreateSession)(ref hSession);
                if (nvAPI_DRS_CreateSessionDelegate != NVAPI_Status.NVAPI_OK)
                {
                    Debug.WriteLine("Failed to create session.");
                    return false;
                }

                //Load settings
                NVAPI_Status nvAPI_DRS_LoadSettings = GetApiIdDelegate<NvAPI_DRS_LoadSettingsDelegate>(NVAPI_Id.NvAPI_DRS_LoadSettings)(hSession);
                if (nvAPI_DRS_LoadSettings != NVAPI_Status.NVAPI_OK)
                {
                    Debug.WriteLine("Failed to load settings.");
                    return false;
                }

                //Get base profile
                NVAPI_Status nvAPI_DRS_GetBaseProfileDelegate = GetApiIdDelegate<NvAPI_DRS_GetBaseProfileDelegate>(NVAPI_Id.NvAPI_DRS_GetBaseProfile)(hSession, ref hProfile);
                if (nvAPI_DRS_GetBaseProfileDelegate != NVAPI_Status.NVAPI_OK)
                {
                    Debug.WriteLine("Failed to get base profile.");
                    return false;
                }

                //Create new setting
                NVDRS_SETTING_V1 drsSetting = new NVDRS_SETTING_V1();
                drsSetting.version = MAKE_NVAPI_VERSION<NVDRS_SETTING_V1>(1);
                drsSetting.settingId = (uint)ESetting.MAXFRAMERATE;
                drsSetting.settingType = NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE;
                drsSetting.settingLocation = NVDRS_SETTING_LOCATION.NVDRS_GLOBAL_PROFILE_LOCATION;

                uint uintHexValue = uint.Parse(maxFrameRate.ToString("X"), NumberStyles.HexNumber);
                NVDRS_SETTING_UNION currentValue = new NVDRS_SETTING_UNION
                {
                    dwordValue = uintHexValue
                };
                drsSetting.currentValue = currentValue;

                //Set new setting
                NVAPI_Status nvAPI_DRS_SetSettingDelegate = GetApiIdDelegate<NvAPI_DRS_SetSettingDelegate>(NVAPI_Id.NvAPI_DRS_SetSetting)(hSession, hProfile, ref drsSetting);
                if (nvAPI_DRS_SetSettingDelegate != NVAPI_Status.NVAPI_OK)
                {
                    Debug.WriteLine("Failed to set setting.");
                    return false;
                }

                //Save new setting
                NVAPI_Status nvAPI_DRS_SaveSettingsDelegate = GetApiIdDelegate<NvAPI_DRS_SaveSettingsDelegate>(NVAPI_Id.NvAPI_DRS_SaveSettings)(hSession);
                if (nvAPI_DRS_SaveSettingsDelegate != NVAPI_Status.NVAPI_OK)
                {
                    Debug.WriteLine("Failed to save settings.");
                    return false;
                }

                //Save new setting
                NVAPI_Status nvAPI_DRS_DestroySessionDelegate = GetApiIdDelegate<NvAPI_DRS_DestroySessionDelegate>(NVAPI_Id.NvAPI_DRS_DestroySession)(hSession);
                if (nvAPI_DRS_DestroySessionDelegate != NVAPI_Status.NVAPI_OK)
                {
                    Debug.WriteLine("Failed to destroy session.");
                    return false;
                }

                Debug.WriteLine("Adjusted the maximum frame rate to: " + maxFrameRate + "fps");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to adjust maximum frame rate: " + ex.Message);
                return false;
            }
        }
    }
}
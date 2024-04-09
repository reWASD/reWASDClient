using System.Runtime.Serialization;
using Newtonsoft.Json;
using reWASDProtocol;
using reWASDProtocol.Converters;
using reWASDProtocol.DataTransferObjects;
using reWASDProtocol.DataTransferObjects.Controllers;
using reWASDProtocol.Infrastructure;
using reWASDProtocol.Infrastructure.Enums;

namespace reWASDHttpClient.Http.Services
{
    public class ControllerService(reWASDProtocol.Client.HttpClient client) : BaseHttpService(client)
    {
        private const string _prefix = $"{Constants.VERSION_PROTOCOL}/ControllerService";

        public async Task<List<BaseControllerDto>> GetControllers()
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/Controllers");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<List<BaseControllerDto>>(await resp.Content.ReadAsStringAsync(), new ControllerConverter())!;
        }

        #region Initialize

        public async Task InitializePeripheral(Guid guid, PeripheralPhysicalType type)
        {
            var deviceInfo = new InitializePeripheralInfo { Guid = guid, Type = type };
            var json = JsonConvert.SerializeObject(deviceInfo);
            var resp = await Client.PostRequestAsync($"{_prefix}/InitializePeripheral", json);
            ProcessResponseError(resp);
        }

        public async Task InitializeGamepad(Guid guid, string deviceType = "")
        {
            var deviceInfo = new InitializeDeviceInfo { Guid = guid, DeviceType = deviceType };
            var json = JsonConvert.SerializeObject(deviceInfo);
            var resp = await Client.PostRequestAsync($"{_prefix}/InitializeGamepad", json);
            ProcessResponseError(resp);
        }

        public async Task ResetInitialization(Guid guid)
        {
            var resp = await Client.PostRequestAsync($"{_prefix}/ResetInitialization/{guid}", null);
            ProcessResponseError(resp);
        }

        #endregion //Initialize

        public async Task<bool> IsControllerPressedButton(Guid guid)
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/IsControllerPressedButton/{guid}");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<bool>(await resp.Content.ReadAsStringAsync());
        }

        public async Task<RemapState> GetRemapState(Guid guid)
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/RemapState/{guid}");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<RemapState>(await resp.Content.ReadAsStringAsync())!;
        }

        public async Task<OutputGamepadInfo> GetOutputGamepad(Guid guid)
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/OutputGamepad/{guid}");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<OutputGamepadInfo>(await resp.Content.ReadAsStringAsync())!;
        }

        public async Task SendGamepadVibration(Guid guid)
        {
            var info = new VibrationInfo
            {
                GamepadGuid = guid,
                Motors = MotorMask.Left | MotorMask.Right,
                Duration = 300,
                Intensity = 50
            };
            var resp = await Client.PostRequestAsync($"{_prefix}/SendGamepadVibration", 
                JsonConvert.SerializeObject(info));
            ProcessResponseError(resp);
        }

        public async Task SetControllerFriendlyName(Guid guid, string friendlyName)
        {
            var resp = await Client.PostRequestAsync(
                $"{_prefix}/SetFriendlyName/{guid}", 
                JsonConvert.SerializeObject(friendlyName));
            ProcessResponseError(resp);
        }

        public async Task<AppliedConfigDto?> GetAppliedConfig(Guid guid, Slot slot)
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/AppliedConfigs/{guid}?slot={slot}");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<AppliedConfigDto>(await resp.Content.ReadAsStringAsync());
        }

        #region Slot
        public async Task<Slot> GetCurrentSlot(Guid guid)
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/CurrentSlot/{guid}");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<Slot>(await resp.Content.ReadAsStringAsync());
        }
        public async Task SelectSlot(Guid guid, Slot slot)
        {
            var slotInfo = new SelectSlotInfo
            {
                Guid = guid,
                Slot = slot
            };

            string json = JsonConvert.SerializeObject(slotInfo);
            var resp = await Client.PostRequestAsync($"{_prefix}/SelectSlot", json);
            ProcessResponseError(resp);
        }
        public async Task ClearSlot(Guid? guid, List<Slot> slots)
        {
            var slotInfo = new ClearSlotInfo
            {
                Guid = guid,
                Slots = slots
            };

            string json = JsonConvert.SerializeObject(slotInfo);
            var resp = await Client.PostRequestAsync($"{_prefix}/ClearSlot", json);
            ProcessResponseError(resp);
        }

        #endregion

        public async Task RemoveOfflineController(Guid guid)
        {
            var resp = await Client.DeleteRequestAsync($"{_prefix}/OfflineController/{guid}");
            ProcessResponseError(resp);
        }

        #region BlackListDevices
        public async Task<List<BlockListGamepadDto>> GetBlocklistDevices()
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/BlocklistDevices");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<List<BlockListGamepadDto>>(await resp.Content.ReadAsStringAsync())!;
        }
        public async Task<bool> SaveBlocklistDevices(List<BlockListGamepadDto> collection)
        {
            var json = JsonConvert.SerializeObject(collection);
            var resp = await Client.PostRequestAsync($"{_prefix}/BlocklistDevices", json);
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<bool>(await resp.Content.ReadAsStringAsync());
        }

        #endregion

        #region CompositeDevices

        public async Task<List<CompositeDeviceDto>> GetCompositeDevices()
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/CompositeDevices");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<List<CompositeDeviceDto>>(await resp.Content.ReadAsStringAsync())!;
        }

        public async Task SaveCompositeDevice(CompositeDeviceDto compositeDevice)
        {
            var json = JsonConvert.SerializeObject(compositeDevice);
            var resp = await Client.PostRequestAsync($"{_prefix}/CompositeDevices", json);
            ProcessResponseError(resp);
        }

        public async Task DeleteCompositeDevice(Guid guid)
        {
            var resp = await Client.DeleteRequestAsync($"{_prefix}/CompositeDevices/{guid}");
            ProcessResponseError(resp);
        }

        #endregion

        #region Apply/Remap

        public async Task ReapplayRemap()
        {
            var resp = await Client.PostRequestAsync($"{_prefix}/ReapplayRemap");
            ProcessResponseError(resp);
        }
        public async Task<bool> ApplyAmiibo(ApplyAmiiboInfo info)
        {
            var json = JsonConvert.SerializeObject(info);
            var resp = await Client.PostRequestAsync($"{_prefix}/ApplyAmiibo", json);
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<bool>(await resp.Content.ReadAsStringAsync());
        }
        public async Task<bool> DisableRemap(Guid? guid)
        {
            var info = new DisableRemapInfo { Guid = guid };
            var json = JsonConvert.SerializeObject(info);
            var resp = await Client.PostRequestAsync($"{_prefix}/DisableRemap", json);
            return CheckResponseError(resp);
        }
        async Task<EnableRemapResponse?> SendEnableRemapRequest(EnableRemapInfo info)
        {
            var json = JsonConvert.SerializeObject(info);
            var resp = await Client.PostRequestAsync($"{_prefix}/EnableRemap", json);
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<EnableRemapResponse>(await resp.Content.ReadAsStringAsync());
        }

        public async Task<bool> ConfigApply(ConfigApplyInfo data)
        {
            var bundle = new EnableRemapBundle { IsUI = true };

            while (true)
            {
                var resp = await SendApplyConfigRequest(data);
                if (resp.IsSucceded)
                    break;

                if (resp.Dialogs.Count == 0)
                {
                    // no dialogs. failure reason unknown
                    return false;
                }

                foreach (var dlg in resp.Dialogs)
                {
                    if (dlg.DefaultButtonNumber >= 0)
                    {
                        try
                        {
                            var defBtn = dlg.Buttons[dlg.DefaultButtonNumber];
                            bundle.UserActions.Add(defBtn.ButtonAction);
                        }
                        catch
                        {
                            Console.WriteLine(dlg.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine(dlg.Message);
                    }
                }

                if (bundle.UserActions.Count == 0 || resp.DontReCallEnableRemap)
                {
                    // no dialog with default user action found. can't apply config
                    return false;
                }

                data.Bundle = bundle;
            }

            return true;
        }

        private async Task<EnableRemapResponse> SendApplyConfigRequest(ConfigApplyInfo info)
        {
            var resp = await Client.PostRequestAsync($"{_prefix}/ApplyConfig", JsonConvert.SerializeObject(info));
            ProcessResponseError(resp);

            var response = JsonConvert.DeserializeObject<EnableRemapResponse>(await resp.Content.ReadAsStringAsync());
            if (response == null)
                throw new SerializationException("EnableRemapResponse is null");
            return response;
        }

        public async Task<bool> EnableRemap(Guid guid, bool remapNonToggledFromRelations)
        {
            var req = new EnableRemapInfo
            {
                Guid = guid,
                RemapNoToggled = remapNonToggledFromRelations,
                Bundle = null
            };

            var bundle = new EnableRemapBundle { IsUI = true };

            while (true)
            {
                req.Bundle ??= new EnableRemapBundle { IsUI = true };

                var resp = await SendEnableRemapRequest(req);
                if (resp == null)
                {
                    Console.WriteLine("Can't enable remap");
                    return false;
                }

                if (resp.IsSucceded)
                    break;
                if (resp?.Dialogs == null || resp.Dialogs.Count == 0)
                {
                    Console.WriteLine("Can't enable remap");
                    return false;
                }

                ShowDialogs(resp.Dialogs, bundle);

                req.Bundle = bundle;
                if (bundle.UserActions.Count == 0 || resp.DontReCallEnableRemap)
                {
                    // no dialog with default user action found. can't apply config
                    return false;
                }
            }

            return true;
        }

        private static void ShowDialogs(List<EnableRemapResponseDialog> dialogs, EnableRemapBundle bundle)
        {
            foreach (var dlg in dialogs)
            {
                if (dlg.DefaultButtonNumber >= 0)
                {
                    try
                    {
                        var defBtn = dlg.Buttons[dlg.DefaultButtonNumber];
                        bundle.UserActions.Add(defBtn.ButtonAction);
                    }
                    catch
                    {
                        Console.WriteLine(dlg.Message);
                    }
                }
                else
                {
                    Console.WriteLine(dlg.Message);
                }
            }
        }

        #endregion
    }
}

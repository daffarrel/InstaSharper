﻿using InstaSharper.API;
using InstaSharper.Helpers;
using Newtonsoft.Json;

namespace InstaSharper.Classes.DeviceInfo
{
    internal class ApiTwoFactorRequestMessage
    {
        internal ApiTwoFactorRequestMessage(string verificationCode, string username, string deviceId,
            string twoFactorIdentifier)
        {
            verification_code = verificationCode;
            this.username = username;
            device_id = deviceId;
            two_factor_identifier = twoFactorIdentifier;
        }

        public string verification_code { get; set; }
        public string username { get; set; }
        public string device_id { get; set; }
        public string two_factor_identifier { get; set; }


        internal string GenerateSignature(ApiVersion apiVersion, string signatureKey = null)
        {
            if (string.IsNullOrEmpty(signatureKey))
                signatureKey = apiVersion.SignatureKey;
            return CryptoHelper.CalculateHash(signatureKey,
                JsonConvert.SerializeObject(this));
        }

        internal string GetMessageString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
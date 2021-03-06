//
// Copyright (c) 2016 deltaDNA Ltd. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using UnityEngine;
using System.Collections;
using DeltaDNA;

namespace DeltaDNAAds {

    internal interface ISmartAdsManager {

        void RegisterForAds(string decisionPoint);
        bool IsInterstitialAdAllowed(Engagement engagement);
        bool IsInterstitialAdAvailable();
        void ShowInterstitialAd();
        void ShowInterstitialAd(string decisionPoint);
        bool IsRewardedAdAllowed(Engagement engagement);
        bool IsRewardedAdAvailable();
        void ShowRewardedAd();
        void ShowRewardedAd(string decisionPoint);
        void EngageResponse(string id, string response, int statusCode, string error);
        void OnPause();
        void OnResume();
        void OnDestroy();
    }

}

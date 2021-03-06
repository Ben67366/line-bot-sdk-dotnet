﻿// Copyright 2017-2018 Dirk Lemstra (https://github.com/dlemstra/line-bot-sdk-dotnet)
//
// Dirk Lemstra licenses this file to you under the Apache License,
// version 2.0 (the "License"); you may not use this file except in compliance
// with the License. You may obtain a copy of the License at:
//
//   https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
// License for the specific language governing permissions and limitations
// under the License.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Line.Tests
{
    public partial class ConfirmTemplateTests
    {
        [TestClass]
        public class TheConstructor
        {
            [TestMethod]
            public void ShouldCreateSerializeableObject()
            {
                var template = new ConfirmTemplate
                {
                    Text = "Test",
                    OkAction = new MessageAction()
                    {
                        Label = "OkLabel",
                        Text = "OkText"
                    },
                    CancelAction = new MessageAction()
                    {
                        Label = "CancelLabel",
                        Text = "CancelText"
                    }
                };

                var serialized = JsonConvert.SerializeObject(template);
                Assert.AreEqual(@"{""type"":""confirm"",""text"":""Test"",""actions"":[{""type"":""message"",""label"":""OkLabel"",""text"":""OkText""},{""type"":""message"",""label"":""CancelLabel"",""text"":""CancelText""}]}", serialized);
            }
        }
    }
}

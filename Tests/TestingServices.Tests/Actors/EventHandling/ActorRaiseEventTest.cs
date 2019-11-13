﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.Coyote.Actors;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Coyote.TestingServices.Tests.Actors
{
    public class ActorRaiseEventTest : BaseTest
    {
        public ActorRaiseEventTest(ITestOutputHelper output)
            : base(output)
        {
        }

        private class E1 : Event
        {
        }

        private class E2 : Event
        {
        }

        [OnEventDoAction(typeof(E1), nameof(HandleE1))]
        [OnEventDoAction(typeof(E2), nameof(HandleE2))]
        private class SomeActor : Actor
        {
            private void HandleE1()
            {
                this.RaiseEvent(new E2());
            }

            private void HandleE2()
            {
                this.Assert(false, "Reached test assertion.");
            }
        }

        [Fact(Timeout=5000)]
        public void TestRaiseEvent()
        {
            this.TestWithError(r =>
            {
                var id = r.CreateActor(typeof(SomeActor));
                r.SendEvent(id, new E1());
            },
            configuration: GetConfiguration(),
            expectedError: "Reached test assertion.",
            replay: true);
        }
    }
}

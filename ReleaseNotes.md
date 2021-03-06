# SignalR Release Notes

# 0.5.2 (Official Release)
* ForeverFrame reconnect error: null frame reference ([#447](https://github.com/SignalR/SignalR/issues/447))
* Error when clicking link (IE only) ([#446](https://github.com/SignalR/SignalR/issues/446))
* Fixed zombie connections issue with forever transports ([7d5204e55d](https://github.com/SignalR/SignalR/commit/7d5204e55d6293881d6eabe85929d02808083027))
* ForeverFrame transport does not handle embedded ```</script>``` tags properly ([#413](https://github.com/SignalR/SignalR/issues/413))
* Made some modifications to js client for SSE and longpolling transports. ([5d782dc3b4](https://github.com/SignalR/SignalR/commit/5d782dc3b45b31183737ea054bb5b4897ed23b76))
* Duplicate connections on reconnect with SSE transport ([#452](https://github.com/SignalR/SignalR/issues/452))
* Added .NET 3.5 Client ([9e3a95c65f](https://github.com/SignalR/SignalR/commit/9e3a95c65fa64ee149e5929318dc6faacc37ef2e))
* Add server variables to the IRequest abstraction ([#438](https://github.com/SignalR/SignalR/issues/438))
* Forever frame slows down in IE after receiving many messages ([#458](https://github.com/SignalR/SignalR/issues/458))
* Reworked connection tracking logic ([8d27c97792](https://github.com/SignalR/SignalR/commit/8d27c977929ef6964a7926e97b3de6b463cd858f))
* Fix connect bug in IE6 with longpolling ([7ab434c02d](https://github.com/SignalR/SignalR/commit/7ab434c02d7d9015689f8988c9ed8456a91c741b))
* Optimized type conversation so we don't end up parsing JSON twice on hub calls  ([50cefbba42](https://github.com/SignalR/SignalR/commit/50cefbba422a46adb1345bd4f22e49be7ecc52d2))
* Clean up the way we use connection state in the .NET Client ([#474](https://github.com/SignalR/SignalR/issues/474))
* Added an overload to Send that allows passing an object (.NET Client) ([9c171bd8e7](https://github.com/SignalR/SignalR/commit/9c171bd8e77f79755aa43a14d0e5ab77e9e50e4a))
* Don't parse the message ID as a long (.NET client) ([#475](https://github.com/SignalR/SignalR/issues/475))
* Prevent hang on Connection.Start() ([5752d6007b](https://github.com/SignalR/SignalR/commit/5752d6007b8751a3bc723fea0405d7a0994ed82e))
* Stop EventSource before calling onFailed ([5c7536131b](https://github.com/SignalR/SignalR/commit/5c7536131bb2b501fff7d2f8a12194df5ac6705f))
* Fixed issues with cross domain websockets ([#461](https://github.com/SignalR/SignalR/issues/461))
* HeartBeat.MarkConnection(this) called twice per Send(..) in ForeverTransport ([#333](https://github.com/SignalR/SignalR/issues/333))

# 0.5.1 (Official Release)
* Windows RT client support ([#171](https://github.com/SignalR/SignalR/issues/171))
* Fixed Race condition in .NET SSE transport ([#341](https://github.com/SignalR/SignalR/issues/341))
* Added reconnect support for Websocket transport ([#395](https://github.com/SignalR/SignalR/issues/395))
* Implemented clean disconnect support on browser close ([#396](https://github.com/SignalR/SignalR/issues/396))
* Added async flush support for ASP.NET 4.5 ([#402](https://github.com/SignalR/SignalR/issues/402))
* Fixed websockets in WinJS client ([407](https://github.com/SignalR/SignalR/issues/407))
* Added connection state and new state changed event to js and .NET client ([431](https://github.com/SignalR/SignalR/issues/431))
* Check connection state before retrying in js client ([af2ae94133](https://github.com/SignalR/SignalR/commit/af2ae941339082ab21d8ea888e486a3c902e4b34))
* Turn keep alive on by default ([47e17b68ce](https://github.com/SignalR/SignalR/commit/47e17b68ce93d74a690dd9a7f918fddeb842fb02))
* Auto detect cross domain ([0a5c62438b](https://github.com/SignalR/SignalR/commit/0a5c62438bc928452bb61f75553635e5bf9e821e))
* Changed IResponse.Write and End to take ArraySegment<byte> instead of string ([f521fd2e6a](https://github.com/SignalR/SignalR/commit/f521fd2e6af967ce3603244bd7ed8606313f48a5))
* Added hubify.exe to generate the hubs file at build time ([e7672ebb60](https://github.com/SignalR/SignalR/commit/e7672ebb60e826d13528783967a88f9db7af56a2))
* Built WebSockets transport into the core.

## v0.5.0 (Official Release)
* Server Send Events connections not closing ([#369](https://github.com/SignalR/SignalR/issues/369))
* Allow HubConnection to specify hub url ([#368](https://github.com/SignalR/SignalR/issues/368))
* Added current IPrincipal to IRequest. ([e381ef1cb6](https://github.com/SignalR/SignalR/commit/e381ef1cb6c0c13087c221abdfa2833c0ae841a6))
* Remove implicit Send overload from PersistentConnection. ([44ff03aafa](https://github.com/SignalR/SignalR/commit/44ff03aafa5f5e2f3b73a5a19ac5a2437674891b))
* Regression: Method overloads no longer work in hubs because of caching. ([#362](https://github.com/SignalR/SignalR/issues/362))

## v0.5.0 RC (Stable Prerelease)
* Performance: Only register for disconnect for chunked requests on self host. (#352)
* Provide way to override default resolver in ASP.NET other than through routing. (#347)
* Performance: Only subscribe to hubs that have method subscriptions (#346)
* Don't create all hub instances on connect/reconnect/disconnect (#345)
* Hub names are case sensitive. (#344)
* Crappy error message when failing to create a hub (#343)
* Performance: InProcessMessageBus<T>.RemoveExpiredEntries takes N+1 locks to remove N entries (#335)
* Performance: Use DateTime.UtcNow instead of DateTime.Now. (7edef25411)
* Fixed incompatibility with jQuery.Validate (#328, #145).
* .NET Client Fixed race condition in Stop() after connection fails. (cd87d40583)
* ReflectedMethodDescriptor::TryGetMethod Executable Method Caching (#351)
* Disconnect is broken in webfarms (#69)

## v0.5.0 (Stable Prerelease)

### Bugs Fixed
* Missing messages in some cases (#307)
* Exception in .NET client when fiddler attached (#304)
* Calling Send multiple times fails (#260)
* Exception in .NET client SSE impl with large messages (#256)
* Invoking Hub methods with byte[] arguments fail (#245)
* Fixed encoding issues with self host (#244)
* Calling Stop then Start after Start fails doesn't restart .NET client (#226)
* Unobserved task exception on long polling transport when server is restarted during first request (#320)
* Hubs in inner classes don't work (#204)
* LongPolling raises IConnected.Reconnect too many times (#188)
* Issues with large message sizes (#163)
* Regression: Reconnect client after server restart (#24)
* Fixed Guids in Hub method parameters (#194)
* SelfHost Server not recognising remote disconnections (#214)
* Removed double deserialize from .NET client. (fbb3ea615d)

### Features
* Mono support (#58)
* Dynamic hubs implementation (#276)
* Improved serveral APIs to be more consistent (#20)
* Cross domain via jsonp (#6)
* Transports need to send "Keep Alives" (#168)
* Add Current User Identity to SignalR.Hosting.Request (#241)
* Added support fo Silverlight 5 Client (#264)


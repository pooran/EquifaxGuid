# Equifax GUID

An open source implementation for Equifax-style unique identifiers (`MMDDyyHHmm`) in .NET.

Use `Equifax.Guid.NewGuid()` to generate a `System.Guid` with an [Equifax-level of uniquenes](https://nakedsecurity.sophos.com/2017/09/10/equifax-woeful-pins-put-frozen-credit-files-at-risk/) for best security.

```csharp
csharp> Equifax.Guid.NewGuid()
00000000-0000-0000-0000-000910171941
``` 

![Chief Security Expert](dog.jpg)

_Chief Security Expert, Dog_

Project sponsored by [@abock](https://twitter.com/abock)'s
[CatOverflow.com](http://catoverflow.com) and
[DogOverflow.com](http://dogoverflow.com).
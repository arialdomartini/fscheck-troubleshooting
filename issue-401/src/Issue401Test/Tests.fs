module Tests

open FsCheck.FSharp
open FsCheck.Xunit
open Issue401.Library

[<Property>]
let ``generated records contain positive ints and not empty strings``() =

    let records =
        ArbMap.defaults
        |> ArbMap.arbitrary<ARecord>
        |> Arb.mapFilter id (fun r -> r.AnInt > 0 && r.AString.Length > 0)

    Prop.forAll records (fun aRecord -> aRecord.AnInt > 0 && aRecord.AString.Length > 0)

[<Property>]
let ``generated union types contain positive ints``() =

    let unionTypes =
        ArbMap.defaults
        |> ArbMap.arbitrary<AUnionType>
        |> Arb.mapFilter id (fun (AUnionType v) -> v > 0)

    Prop.forAll unionTypes (fun (AUnionType v) -> v > 0)

[<Property>]
let ``generated tuples contain positive ints``() =

    let tuples =
        ArbMap.defaults
        |> ArbMap.arbitrary<ATuple>
        |> Arb.mapFilter id (fun (i, s) -> i > 0 && s.Length > 0)

    Prop.forAll tuples (fun (i, s) -> i > 0 && s.Length > 0)

[<Property>]
let ``generated classes instance contain positive ints``() =

    let classInstances =
        ArbMap.defaults
        |> ArbMap.arbitrary<AClass>
        |> Arb.mapFilter id (fun c -> c.I > 0)

    Prop.forAll classInstances (fun c -> c.I > 0)

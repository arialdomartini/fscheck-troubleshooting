module Tests

open FsCheck.Xunit
open Swensen.Unquote

[<Property>]
let ``always green`` () =
    test <@ true = true @>

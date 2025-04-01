namespace Issue401.Library

type internal ARecord = { AString: string; AnInt: int }
type internal AUnionType = internal AUnionType of int
type internal ATuple = (int * string)

type internal AClass =
    val private i: int
    internal new(i: int) = { i = i }
    member this.I = this.i

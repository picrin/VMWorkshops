Module ArrayElement

  Function Inverse(ByRef arr as Integer(), ByRef i as Integer) as Integer
    arr(i) = -1 * arr(i)
    return arr(i)
  End Function

  Function Main() as Integer
    Dim elemArray as Integer()
    Dim i
    elemArray = new Integer() {1, 2, 3}
    i = 1
    Inverse(elemArray, i)
    Console.WriteLine(elemArray(i))
    return 0
  End Function

End Module

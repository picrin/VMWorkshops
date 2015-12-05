Module ArrayElement
  Function Main() as Integer
    Dim elemArray as Integer()
    Dim i as Integer
    elemArray = new Integer() {1, 2, 3}
    i = 1
    Console.WriteLine(elemArray(i))
    return 0
  End Function
End Module

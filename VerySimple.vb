Module ArrayElement

  Function F(ByRef x as Integer) as Integer
    return x
  End Function

  Function Main() as Integer
    Dim a As Integer
    a = 1
    F(a)
    return 0
  End Function

End Module

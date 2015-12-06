Module MonsterGame
  Function monsterLookup(Byref food as String) as String
    Dim monster as String
    If food = "carrot"
      monster = "cyber bunny"
    End If
    If food = "fear"
      monster = "headless ghost"
    End If
    If food = "raw steak"
      monster = "ferocious zombie"
    End If
    If food = "beetroot"
      monster = "tactful vegpire"
    End If
    If monster = ""
      monster = "nameless monstrosity"
    End If
    return monster
  End Function

  Function Main() as Integer
    Dim monsterName as String
    Dim foodType as String
    Console.Writeline("Would you have some carrot, fear, beetroot or raw steak?")
    foodType = Console.ReadLine()
    monsterName = monsterLookup(foodType)
    Console.WriteLine("you are a " & monsterName)
    return 0
  End Function

End Module

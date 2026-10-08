Svar på frågor givna i övningen

Filenotfoundexception: Byt namn på filen alt. ta bort filen helt och hållet
Formatexception: Filen innehåller andra tecken än siffror
Dividebyzerexception: Filen innehåller en/flera nollor (endast)
InvalidOperationException rad 70: Filen saknar innehåll
Exception rad 62 ges ifall programmet inte får in en filpath (ta bort numbers.txt i andropet)

Förändringar:
Gjorde om checken på rad 70 till en check enligt dotnet språkregler https://learn.microsoft.com/sv-se/dotnet/fundamentals/code-analysis/style-rules/ide0029-ide0030-ide0270
Lade till en check för interna fel på den generella felhandlingen i main på rad 34
Lade till en regexcheck så programmet inte försöker convertera något som inte går (miniskul sparande av resurser)
Lade till en 0 check på rad 79 av samma anledning som ovan
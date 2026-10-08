Svar på frågor givna i övningen

1. Filenotfoundexception: Byt namn på filen alt. ta bort filen helt och hållet
2. Formatexception: Filen innehåller andra tecken än siffror
3. Dividebyzerexception: Filen innehåller en/flera nollor (endast)
4. InvalidOperationException rad 70: Filen saknar innehåll
5. Exception rad 62 ges ifall programmet inte får in en filpath (ta bort numbers.txt i andropet)

Förändringar i koden:

1. Gjorde om checken på rad 70 till en check enligt dotnet språkregler https://learn.microsoft.com/sv-se/dotnet/fundamentals/code-analysis/style-rules/ide0029-ide0030-ide0270
2. Lade till en check för interna fel på den generella felhandlingen i main på rad 34
3. Lade till en regexcheck så programmet inte försöker convertera något som inte går (miniskul sparande av resurser)
4. Lade till en 0 check på rad 79 av samma anledning som ovan
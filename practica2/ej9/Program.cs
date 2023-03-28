/* el tipo StringBuilder es ampliamente superior 
cuando se debe construir el string poco a poco, por
ejemplo una ruta de archivo, no es mas util cuando
se necesita usarlo como parametro

Conclusion
StringBuilder executes significantly faster than the String class when performing the concatenation or modification operations.
Modifying a String creates a new String in the heap memory. To change the content of the String, we should consider the StringBuilder class.
Any attempt to modify the String class creates a new object in the heap memory, which has significant performance drawbacks.
StringBuilder is ideal for modifying string content; it does so without creating any extra objects in the memory.

Conclusion propia:
El string builder ejecuta mucho mas rapido en un nivel de concatenacion muy alto, sin embargo, es mas simple usar el string en casos donde 
agregar o concatenar las palabras sea en un nivel bajo <> es decir pocas modificaciones.
*/
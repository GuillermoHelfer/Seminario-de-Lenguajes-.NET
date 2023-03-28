List<int> a = new List<int>() { 1, 2, 3, 4 };
a.Remove(5); //devuelve true si pudo remover el item especificado
a.RemoveAt(4); //remueve el item de la pos indicada, arroja error out of bound, las posiciones comienzan en 0
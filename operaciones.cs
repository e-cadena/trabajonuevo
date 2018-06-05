double inicial=3;
var superCalcu= newCalculadora();
var resultSuma = superCalcu.Sumar(inicial,2);
var resultResta = superCalcu.Restar(resultSuma,3);
var result = superCalcu.Radicar(resultResta);
var result = superCalcu.Dividir(result,8);
var result = superCalcu.Multiplicar(resultado,4);
console.writeLine("El resultado es: " +result);

# Práctica Pruebas Unitarias

Realizar las pruebas unitarias que considere importantes para comprobar el correcto funcionamiento de la entidad del dominio ProcesadorMatematico (siéntanse libres de modificar el código de la clase si así lo considera).

 - Antes de iniciar los Test, es importante modificar la clase *ProcesadorMatematico* para que exponga los resultados de los cálculos, ya que sin ese dato no podemos comprobar por completo el correcto funcionamiento de la misma.
 - Además, es importante tratar la posibilidad de división por cero. Una de las formas es alterando el método *Dividir()* para que arroje una excepción para ese caso.
 - Luego, las pruebas unitarias que podrían ejecutarse son:
	 - Sumar_ConNumerosPositivos_DevuelveResultadoSuma()
	 - Sumar_ConNumerosNegativos_DevuelveCero()
	 - Dividir_ConNumerosPositivos_DevuelveResultadoDivision()
	 - Dividir_ConNumerosNegativos_DevuelveCero()
	 - Dividir_DivisorCero_ArrojaExcepcion()
	 - CalcularMayor_ConPrimerValorMayor_DevelvePrimerValor(), opcionalmente se puede pasar una lista de valores con *Theory*
   

Proceso ejercicio_25
	//Definir 
	Definir nota Como real;
	//operacion de entrada
	Escribir "digite su nota (0-5)";
	Leer nota;
	//salida
	si (nota<0) o (nota>5) Entonces
		escribir "esta nota no es valida";
	SiNo
		si (nota<=2.9) Entonces
			Escribir "insuficiente";
		SiNo
			si (nota>=3 y nota<=4.5) Entonces
				Escribir "suficiente";
			SiNo
				//si (nota>=4.6) Entonces
					Escribir "bien";
				//FinSi
			FinSi
		FinSi
	FinSi
FinProceso

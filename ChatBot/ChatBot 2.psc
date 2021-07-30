Algoritmo sin_titulo
	Definir w,q,n,cantidad,Num,suma,x,p,i Como Entero
	Definir l,u,respuesta Como Real
	Definir continuar,Nombre Como Caracter
	Escribir 'Hola me llamo BMO, soy un ChatBot ¿Como te llamas?'
	Leer Nombre
	Repetir
		Escribir 'Hola ',Nombre,' ¿Cómo puedo ayudate?'
		Escribir ''
		Escribir 'Menu'
		Escribir ''
		Escribir '1.- Relizar una operacion matematica'
		Escribir '2.- Calcular el areas'
		Escribir '3.- Salir'
		Leer q
		Si q=1 Entonces
			Repetir
				Escribir 'Realizar una operacion matematica'
				Escribir ''
				Escribir '1.- Suma'
				Escribir '2.- Resta'
				Escribir '3.- Multiplicacion'
				Escribir '4.- divicion'
				Escribir '5.- Salir'
				Escribir ''
				Escribir 'Ingresa una respuesta para continuar'
				Leer p
				Segun p  Hacer
					1:
						// Suma
						Escribir ''
						Escribir 'Suma'
						Escribir ''
						Escribir 'Ingresa la cantidad de datos a sumar'
						Leer cantidad
						suma <- 0
						Para i<-1 Hasta cantidad Hacer
							Escribir ''
							Escribir 'Ingrese la cantidad'
							Leer Num
							suma <- suma+Num
						FinPara
						Escribir 'El resultado es: ',suma
					2: // Resta 
						Escribir ''
						Escribir 'Resta'
						Escribir ''
						Escribir 'Ingresa la cantidad de datos a restar'
						Leer cantidad
						suma <- 0
						Para i<-1 Hasta cantidad Hacer
							Escribir ''
							Escribir 'Ingrese la cantidad'
							Leer Num
							suma <- suma-Num
						FinPara
						Escribir 'El resultado es: ',suma
					3: // Multiplicacion
						Escribir ''
						Escribir 'Multiplicacion'
						Escribir ''
						Escribir 'Ingresa la cantidad de datos a multiplicar'
						Leer cantidad
						suma <- 0
						Para i<-1 Hasta cantidad Hacer
							Escribir ''
							Escribir 'Ingrese la cantidad'
							Leer Num
							suma <- suma*Num
						FinPara
						Escribir 'El resultado es: ',suma
					4: // Divicion
						Escribir ''
						Escribir 'Divicion'
						Escribir ''
						Escribir 'Ingrese el valor del dividendo'
						Leer n
						Escribir ''
						Escribir 'Ingresa el vañor de divisor'
						Leer l
						respuesta <- n/l
						Escribir 'El resultado es: ',respuesta
					5: // Salir 	
					De Otro Modo:
						Escribir 'Error'
				FinSegun
				Escribir '¿Desea continuar? (y/n)'
				Leer continuar
			Hasta Que continuar<>'y'
		FinSi
		Si q=2 Entonces
			Repetir
				Escribir 'Calcular el area'
				Escribir ''
				Escribir '1.- Circulp'
				Escribir '2.- Cuadrado'
				Escribir '3.- Triangulo rectangulo'
				Escribir '4.- Rectangulo'
				Escribir '5.- Salir'
				Escribir ''
				Escribir 'Ingresa una respuesta para continuar'
				Leer p
				Segun p  Hacer
					1:
						Escribir ''
						Escribir 'Circulo'
						Escribir ''
						Escribir 'Ingrese el valor del radio'
						Leer w
						respuesta <- 3.141592*(w^2)
						Escribir 'El area del circulo es: ',respuesta
					2:
						Escribir ''
						Escribir 'Cuadrado'
						Escribir ''
						Escribir 'Ingresa el valor de algun de los lados del cadrado'
						Leer cantidad
						respuesta <- cantidad^2
						Escribir 'El resultado es:',respuesta
					3:
						Escribir ''
						Escribir 'Triangulo rectangulo'
						Escribir ''
						Escribir 'Ingresa el valor de la base'
						Leer cantidad
						Escribir 'Ingresa el valor del lado que coincida con la altura'
						Leer n
						respuesta <- cantidad*n/2
						Escribir 'El resultado es: ',respuesta
					4:
						Escribir ''
						Escribir 'Rectangulo'
						Escribir ''
						Escribir 'Ingresa el valor del largo del cuadrado'
						Leer cantidad
						Escribir 'Ingresa el valor del ancho del cuadrado'
						Leer n
						respuesta <- catidad*n
						Escribir 'El resultado es: ',respuesta
					5: // Error
					De Otro Modo:
						Escribir 'Error'
				FinSegun
				Escribir '¿Desea continuar? (y/n)'
				Leer continuar
			Hasta Que continuar<>'y'
		SiNo
			q <- 3
		FinSi
		Escribir '¿Desea salir? (y/n)'
		Leer continuar
	Hasta Que continuar<>'n'
FinAlgoritmo

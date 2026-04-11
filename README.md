<<<<<<< HEAD
=======
[README.md](https://github.com/user-attachments/files/26586658/README.md)
>>>>>>> c180e46e55db9fee0fcb35f4c82163c644c36d2e
# 📘 Práctico - Programación III

> **Materia:** Programación III (Práctica)  
> **Profesor:** Rodrigo Esper  
> **Alumno:** Pablo Bejas  
> **Carrera:** Tecnicatura Universitaria en Programación  
> **Universidad:** Universidad Tecnológica Nacional – Facultad Regional Tucumán  
> **Lenguaje:** C# (.NET 10.0) – Aplicación de Consola

---

## 📋 Resumen del Sistema

Este repositorio contiene una colección de **ejercicios prácticos de consola** desarrollados en **C#** como parte de la materia **Programación III**. El sistema está diseñado como un **menú interactivo** que permite al usuario seleccionar y ejecutar distintos programas/ejercicios numerados del 0 al 10.

Cada ejercicio aborda un tema específico de la programación en C#, desde los conceptos más básicos (como "Hola Mundo") hasta tipos de datos fundamentales (`int`, `float`, `double`, `decimal`, `string`, `bool`), constantes, inferencia de tipos con `var` y tipos nullables.

La aplicación cuenta con una **interfaz de consola estilizada** con colores, títulos centrados, validación de entrada del usuario y un diseño visual uniforme en todos los ejercicios.

---

## 🏗️ Estructura del Proyecto

```
Practico-ProgramacionIII/
├── Program.cs          → Punto de entrada y menú principal del sistema
├── Funciones.cs        → Clase de utilidades (funciones auxiliares reutilizables)
├── Program00.cs        → Ejercicio 00: Hola Mundo
├── Program01.cs        → Ejercicio 01: Registro y Login de Usuario
├── Program02.cs        → Ejercicio 02: Tipos de Datos - int (Entero)
├── Program03.cs        → Ejercicio 03: Tipos de Datos - float, double y decimal
├── Program04.cs        → Ejercicio 04: Tipos de Datos - string (Cadena de Caracteres)
├── Program05.cs        → Ejercicio 05: Tipos de Datos - bool (Booleano)
├── Program06.cs        → Ejercicio 06: Constantes (En Construcción)
├── Program07.cs        → Ejercicio 07: Constantes - Facturación (En Construcción)
├── Program08.cs        → Ejercicio 08: Inferencia de Tipos con var (En Construcción)
├── Program09.cs        → Ejercicio 09: Nullable Reference Types (En Construcción)
├── Program10.cs        → Ejercicio 10: Operador de Acceso Condicional (En Construcción)
└── Practico-ProgramacionIII.csproj → Archivo de configuración del proyecto (.NET 10.0)
```

---

## 🌐 Variables Globales

Las variables globales del sistema están definidas dentro de la clase estática `Globales`, ubicada dentro de la clase `Program` en el archivo `Program.cs`:

| Variable | Tipo | Valor | Descripción |
|---|---|---|---|
| `pieDePagina` | `string` | `"Programación III (Práctica) - Profesor: Rodrigo Esper - Alumno: Pablo Bejas"` | Texto que se muestra como pie de página en la parte inferior de la consola en todos los ejercicios. |
| `colorTextoMensaje` | `ConsoleColor` | `ConsoleColor.White` | Color estándar para los mensajes de texto generales. |
| `colorTextoTitulo` | `ConsoleColor` | `ConsoleColor.DarkYellow` | Color utilizado para los títulos y encabezados de secciones. |
| `colorTextoVineta` | `ConsoleColor` | `ConsoleColor.DarkRed` | Color utilizado para las viñetas de los incisos (a., b., c., etc.). |

Estas variables se acceden desde cualquier parte del sistema mediante `Program.Globales.nombreVariable` y permiten mantener una **apariencia visual consistente** en toda la aplicación.

---

## ⚙️ Clase `Funciones` – Funciones Auxiliares

La clase `Funciones` (archivo `Funciones.cs`) contiene **métodos estáticos utilitarios** que se reutilizan en todos los ejercicios del sistema. A continuación se describe cada una:

---

### 🎨 `TextoEnColor(string texto, ConsoleColor colorTexto, ConsoleColor colorOriginal)`

**Propósito:** Escribe un texto en la consola con un color específico y luego restaura el color original.

| Parámetro | Tipo | Descripción |
|---|---|---|
| `texto` | `string` | El texto a mostrar en consola. |
| `colorTexto` | `ConsoleColor` | El color con el que se mostrará el texto. |
| `colorOriginal` | `ConsoleColor` | El color al que se restaura después de imprimir. |

**Uso típico:** Resaltar palabras clave, valores o resultados dentro de una línea de texto.

---

### 🔢 `ReadInteger(string mensaje, ConsoleColor colorTexto)` → `int`

**Propósito:** Solicita al usuario un número entero con validación. Si el usuario ingresa un valor no numérico, muestra un mensaje de error y permite reintentar **sin perder la posición del cursor**.

| Parámetro | Tipo | Descripción |
|---|---|---|
| `mensaje` | `string` | El texto del prompt que se muestra al usuario. |
| `colorTexto` | `ConsoleColor` | El color del texto del mensaje. |

**Retorna:** Un valor `int` válido ingresado por el usuario.

**Comportamiento de error:**
- Muestra en rojo: *"No se ingresó un número entero"*.
- Muestra en cian: *"Presiona cualquier tecla para intentar nuevamente..."*.
- Limpia la entrada errónea y reposiciona el cursor para un nuevo intento.

---

### 📝 `ReadString(string mensaje, int cantidadCaracteresMinimo, int cantidadCaracteresMaximo, ...)` → `string`

**Propósito:** Solicita al usuario una cadena de texto con validación de longitud mínima y máxima. Ofrece opciones avanzadas de color y control de errores.

| Parámetro | Tipo | Valor por defecto | Descripción |
|---|---|---|---|
| `mensaje` | `string` | – | El texto del prompt que se muestra al usuario. |
| `cantidadCaracteresMinimo` | `int` | – | Cantidad mínima de caracteres aceptados. |
| `cantidadCaracteresMaximo` | `int` | – | Cantidad máxima de caracteres aceptados. |
| `colorTextoMensaje` | `ConsoleColor` | `White` | Color del texto del mensaje/prompt. |
| `colorTextoValor` | `ConsoleColor` | `White` | Color del texto que escribe el usuario (útil para ocultar contraseñas usando `Black`). |
| `checkError` | `bool` | `true` | Si es `false`, no valida longitud y devuelve el valor directamente. |

**Retorna:** Un `string` válido ingresado por el usuario.

**Comportamiento de error:**
- Muestra en rojo: *"Debe Ingresar entre X y Y caracteres"*.
- Permite reintentar limpiando la entrada anterior.

---

### ⏸️ `EsperarTeclaFinal()`

**Propósito:** Muestra un mensaje de "Programa Finalizado" y espera a que el usuario presione una tecla para continuar. Se utiliza al final de cada ejercicio para pausar la ejecución antes de volver al menú.

**Comportamiento:**
- Posiciona el cursor 2 líneas más abajo.
- Muestra en cian: *"Programa Finalizado"* y *"Presione cualquier tecla para continuar"*.
- Oculta el cursor durante la espera.

---

### 📌 `MostrarTitulo(string titulo, ConsoleColor colorTexto, int linea)`

**Propósito:** Muestra un texto **centrado horizontalmente** en la consola en una línea específica. También actualiza el título de la ventana de la consola.

| Parámetro | Tipo | Descripción |
|---|---|---|
| `titulo` | `string` | El texto del título a mostrar. |
| `colorTexto` | `ConsoleColor` | El color del texto. |
| `linea` | `int` | La fila (posición vertical) donde se mostrará el título. |

**Uso típico:** Encabezados de ejercicios, pie de página, y marcos decorativos del menú.

---

### 🚧 `ProgramaEnConstruccion()`

**Propósito:** Muestra una pantalla informativa centrada indicando que el programa seleccionado aún está en construcción. Se utiliza en los ejercicios que aun no fueron realizados.

**Comportamiento:**
- Limpia la consola.
- Muestra en amarillo y centrado:
  - *"Programa en Construcción"*
  - *"En breve será puesto en funcionamiento"*
  - *"Disculpe las molestias ocasionadas"*
  - *"Presione Una Tecla Para Volver"*
- Muestra el pie de página global.
- Espera una tecla para volver al menú.

---

### 🔚 `EsperarFinalSistema()`

**Propósito:** Muestra una pantalla de despedida cuando el usuario elige salir del sistema (opción 99).

**Comportamiento:**
- Limpia la consola.
- Muestra en verde oscuro y centrado:
  - *"Sistema Finalizado."*
  - *"Gracias por su tiempo"*
  - *"Presione cualquier tecla para salir"*
- Oculta el cursor y cambia el color del texto a negro.

---

## 📚 Descripción de Ejercicios

### Program 00 – Hola Mundo (`Program00.cs`)

**Tema:** Introducción básica – Salida por consola.

El clásico primer programa. Muestra un mensaje de presentación personal con texto en colores, indicando nombre, la materia que curso (**Programación III**), la carrera (**Tecnicatura Universitaria en Programación**) y la universidad (**UTN – FRT**).

**Conceptos trabajados:**
- `Console.WriteLine()` y `Console.Write()`
- Uso de `Console.ForegroundColor` para cambiar colores de texto
- `Console.ResetColor()` para restaurar el color predeterminado

---

### Program 01 – Registro y Login de Usuario (`Program01.cs`)

**Tema:** Variables de tipo `string`, entrada del usuario, comparación de valores.

Simula un sistema de registro e inicio de sesión en dos fases:

1. **Fase de registro:** solicita al usuario un nombre de usuario (4-20 caracteres), una contraseña (4-15 caracteres, texto oculto en negro) y un nombre completo (4-40 caracteres).
2. **Fase de login:** presenta un formulario visual con bordes dibujados en consola donde el usuario debe ingresar sus credenciales.
3. **Validación:** compara las credenciales ingresadas con las registradas y muestra un mensaje de bienvenida o de error.

**Conceptos trabajados:**
- Declaración y uso de variables `string`
- Comparación de cadenas con `==`
- Diseño visual de formularios en consola con caracteres ASCII
- Uso de `Console.SetCursorPosition()` para posicionar texto

---

### Program 02 – Tipos de Datos: `int` (Entero) (`Program02.cs`)

**Tema:** Tipo de dato `int`, operaciones aritméticas.

Explica qué es el tipo de dato `int` en C#, su rango de valores (-2,147,483,648 a 2,147,483,647) y su uso en memoria (4 bytes). Luego muestra ejemplos prácticos:

- **Declaración:** `int edad = 35;`, `int indice = 4;`, `int cantidadProductos = 12;`
- **Operaciones aritméticas** con `a = 10` y `b = 3`:
  - Suma (`+`): resultado 13
  - Resta (`-`): resultado 7
  - Multiplicación (`*`): resultado 30
  - División entera (`/`): resultado 3 (trunca la parte decimal)
  - Módulo (`%`): resultado 1 (resto de la división)

**Conceptos trabajados:**
- Tipo de dato `int` y su rango
- Operadores aritméticos básicos: `+`, `-`, `*`, `/`, `%`
- Truncamiento de la división entera

---

### Program 03 – Tipos de Datos: `float`, `double` y `decimal` (`Program03.cs`)

**Tema:** Tipos de datos con decimales y sus diferencias.

Explica las diferencias entre los tres tipos de datos con punto decimal en C#:

| Tipo | Tamaño | Sufijo | Uso recomendado |
|---|---|---|---|
| `float` | 4 bytes | `f` | Gráficos, videojuegos, cálculos rápidos |
| `double` | 8 bytes | `d` (optativo) | Cálculos científicos, matemáticos |
| `decimal` | 16 bytes | `m` | Dinero, finanzas, contabilidad |

**Ejemplos mostrados:**
- `float velocidad = 10.5f;`
- `decimal precio = 19.99m;`
- `double pi = 3.14159265358979d;`

**Conceptos trabajados:**
- Diferencias entre `float`, `double` y `decimal`
- Sufijos literales (`f`, `d`, `m`)
- Precisión vs. rendimiento en tipos numéricos

---

### Program 04 – Tipos de Datos: `string` (Cadena de Caracteres) (`Program04.cs`)

**Tema:** Manipulación de cadenas de texto.

Se divide en dos partes:
1. **Explicación teórica:** qué es un `string`, cómo declararlo y un ejemplo práctico.
2. **Ejercicio interactivo:** El usuario ingresa su nombre completo y el programa calcula y muestra:
   - **a.** El nombre completo tal como fue ingresado.
   - **b.** La cantidad de caracteres (sin contar espacios), usando un bucle `for`.
   - **c.** La cantidad de palabras, usando `Split(' ')`.
   - **d.** Las iniciales del nombre.
   - **e.** El nombre en mayúsculas (`ToUpper()`) y minúsculas (`ToLower()`).
   - **f.** El nombre al revés, construido carácter por carácter con un bucle.

**Conceptos trabajados:**
- Declaración y manipulación de `string`
- Métodos de `string`: `.Length`, `.Split()`, `.ToUpper()`, `.ToLower()`, `.Trim()`
- Acceso a caracteres por índice `nombre[i]`
- Bucles `for` para recorrer cadenas
- Concatenación de cadenas

---

### Program 05 – Tipos de Datos: `bool` (Booleano) (`Program05.cs`)

**Tema:** Variables booleanas, operadores lógicos y expresiones condicionales.

Es el ejercicio más extenso. Presenta una explicación del tipo `bool` y luego ofrece un **submenú con 5 ejercicios**:

#### Ejercicio 1 – Login con booleanos
Solicita usuario y contraseña y usa variables `bool` para determinar:
- `usuarioEsCorrecto`: si el usuario coincide.
- `contrasenaEsCorrecta`: si la contraseña coincide.
- `accesoConcedido`: resultado del operador `&&` (AND lógico).
- Mensaje especial si el usuario es correcto pero la contraseña no.

#### Ejercicio 2 – Aprobación de alumno
Pide 3 notas enteras y determina si el alumno aprueba (todas las notas ≥ 6) usando `&&`.

#### Ejercicio 3 – Rango válido
Pide un número entero y determina si está dentro del rango 10-50 (exclusivo) usando `&&`.

#### Ejercicio 4 – Ingreso a evento
Pide edad y si tiene documento. El acceso se concede solo si es mayor de 18 **Y** tiene documento (operador `&&`).

#### Ejercicio 5 – Puede ver una película
Pide edad y si está acompañado por un adulto. Puede verla si tiene 16+ **O** está acompañado (operador `||`).

**Conceptos trabajados:**
- Tipo de dato `bool`
- Operadores lógicos: `&&` (AND), `||` (OR), `!` (NOT)
- Operador ternario `? :`
- Expresiones `switch` con pattern matching
- Submenú de ejercicios con `Dictionary` y delegados `Action`

---

### Program 06 – Constantes: GameMaster Pro (`Program06.cs`) 🚧

**Estado:** En construcción.

Introduce el concepto de **constantes** (`const`) con un ejemplo de una aplicación de videojuegos:
- `NOMBRE_APP = "GameMaster Pro"`
- `VERSION = "v1.0.2"`
- `EDAD_MINIMA = 18`
- Evaluación de una expresión booleana constante: `PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA`

**Conceptos trabajados:**
- Palabra clave `const`
- Constantes de tipo `string`, `int` y `bool`
- Expresiones booleanas en tiempo de compilación

---

### Program 07 – Constantes: Facturación (`Program07.cs`) 🚧

**Estado:** En construcción.

Simula un módulo de facturación usando constantes:
- `TASA_IVA = 0.21m` (21% de IVA)
- `MODO_PRUEBA = false`
- `SIMBOLO_PESO = '$'`
- Calcula precio base + IVA y muestra el total a pagar.

**Conceptos trabajados:**
- Constantes de tipo `decimal`, `bool` y `char`
- Cálculos aritméticos con `decimal`
- Concatenación de `char` con `string`

---

### Program 08 – Inferencia de Tipos con `var` (`Program08.cs`) 🚧

**Estado:** En construcción.

Demuestra la inferencia de tipos con la palabra clave `var`:
- `var x = 10;` → se infiere como `int`
- `var y = 3.14;` → se infiere como `double`
- `var mensaje = "Hola sin control";` → se infiere como `string`
- Uso de `List<int>` con inicialización y acceso por índice.
- Casting explícito de `double` a `int` con `(int)y`.

**Conceptos trabajados:**
- Palabra clave `var` e inferencia de tipos
- Colecciones `List<int>` con inicialización en línea
- Casting explícito de tipos

---

### Program 09 – Nullable Reference Types (`Program09.cs`) 🚧

**Estado:** En construcción.

Ejemplo introductorio sobre **tipos de referencia nullables**:
- Muestra cómo acceder a `.Length` de un `string` normal es seguro.
- Muestra (comentado) cómo acceder a `.Length` de un `string?` puede generar un warning de compilación por posible referencia nula.

**Conceptos trabajados:**
- Tipos de referencia nullables (`string?`)
- Warnings de compilación por posible `null reference`
- Directiva `<Nullable>enable</Nullable>` en el `.csproj`

---

### Program 10 – Operador de Acceso Condicional `?.` (`Program10.cs`) 🚧

**Estado:** En construcción.

Demuestra el **operador de acceso condicional** (`?.`) también conocido como *null-conditional operator*:
- `string? texto = null;`
- `int? longitud = texto?.Length;` → el resultado es `null` en lugar de lanzar una excepción.

**Conceptos trabajados:**
- Operador `?.` (null-conditional)
- Tipos de valor nullables (`int?`)
- Prevención de `NullReferenceException`

---

## 🛠️ Tecnologías Utilizadas

- **Lenguaje:** C# 13
- **Framework:** .NET 10.0
- **Tipo de Proyecto:** Aplicación de Consola (Exe)
- **IDE recomendado:** Visual Studio 2022+
- **Características habilitadas:**
  - `ImplicitUsings`: Importaciones implícitas de namespaces comunes.
  - `Nullable`: Análisis de tipos nullables habilitado.

---

## 🚀 Cómo Ejecutar

1. Asegúrate de tener instalado el [SDK de .NET 10.0](https://dotnet.microsoft.com/download).
2. Abrí una terminal en la carpeta del proyecto (preferentemente git bash maximizado).
3. Ejecutá:

```bash
dotnet run
```

4. Se mostrará el **Menú de Programas**. Ingresá el número del ejercicio que quieras ejecutar.
5. Para salir, ingresá `99`.

---

## 📄 Licencia

Proyecto académico – Uso educativo.

# 📘 Práctico - Programación III

> **Materia:** Programación III (Práctica)  
> **Profesor:** Rodrigo Esper  
> **Alumno:** Pablo Bejas  
> **Carrera:** Tecnicatura Universitaria en Programación  
> **Universidad:** Universidad Tecnológica Nacional – Facultad Regional Tucumán  
> **Lenguaje:** C# (.NET 10.0) – Aplicación de Consola

---

## 📋 Resumen del Sistema

Este repositorio contiene una colección de **ejercicios prácticos de consola** desarrollados en **C#** como parte de la materia **Programación III**. El sistema está diseñado como un **menú interactivo navegable con flechas** (↑/↓) que permite al usuario seleccionar y ejecutar distintos programas/ejercicios numerados del 0 al 10.

Cada ejercicio aborda un tema específico de la programación en C#, desde los conceptos más básicos (como "Hola Mundo") hasta tipos de datos fundamentales (`int`, `float`, `double`, `decimal`, `string`, `bool`), constantes, constantes de cálculo/control/representación, inferencia de tipos con `var` y tipos nullables.

La aplicación cuenta con una **interfaz de consola estilizada** con colores, títulos recuadrados y centrados, menú interactivo con resaltado de selección, validación de entrada del usuario, enmascaramiento de contraseñas y un diseño visual uniforme en todos los ejercicios.

---

## 🏗️ Estructura del Proyecto

```
Practico-ProgramacionIII/
├── Clases.cs           → Clases auxiliares: OpcionMenu y Variables Globales
├── Funciones.cs        → Clase de utilidades (funciones auxiliares reutilizables)
├── Program.cs          → Punto de entrada y menú principal del sistema
├── Program00.cs        → Ejercicio 00: Hola Mundo
├── Program01.cs        → Ejercicio 01: Registro y Login de Usuario
├── Program02.cs        → Ejercicio 02: Tipos de Datos - int (Entero)
├── Program03.cs        → Ejercicio 03: Tipos de Datos - float, double y decimal
├── Program04.cs        → Ejercicio 04: Tipos de Datos - string (Cadena de Caracteres)
├── Program05.cs        → Ejercicio 05: Tipos de Datos - bool (Booleano)
├── Program06.cs        → Ejercicio 06: Constantes
├── Program07.cs        → Ejercicio 07: Constantes de Cálculo, Control y Representación
├── Program08.cs        → Ejercicio 08: Inferencia de Tipos con var (En Construcción)
├── Program09.cs        → Ejercicio 09: Nullable Reference Types (En Construcción)
├── Program10.cs        → Ejercicio 10: Operador de Acceso Condicional (En Construcción)
└── Practico-ProgramacionIII.csproj → Archivo de configuración del proyecto (.NET 10.0)
```

---

## 🧩 Clases Auxiliares (`Clases.cs`)

### Clase `OpcionMenu`

Representa una opción dentro del menú interactivo del sistema. Se utiliza para construir dinámicamente los menús navegables con flechas.

| Propiedad | Tipo | Descripción |
|---|---|---|
| `Valor` | `int` | Valor numérico asociado a la opción (se devuelve al seleccionarla). |
| `Titulo` | `string` | Texto principal de la opción (ej: `"Program 00: "`). |
| `TituloColor` | `string` | Texto secundario que se muestra resaltado en otro color (ej: `"Hola Mundo!!!"`). |
| `Ejecutar` | `Action` | Delegado con la acción a ejecutar cuando se selecciona la opción. |

### Clase `Globales`

Contiene las **variables globales estáticas** del sistema que definen la apariencia visual de toda la aplicación:

| Variable | Tipo | Valor | Descripción |
|---|---|---|---|
| `pieDePagina` | `string` | `"Programación III (Práctica) - Profesor: Rodrigo Esper - Alumno: Pablo Bejas"` | Texto que se muestra como pie de página en la parte inferior de la consola. |
| `colorTextoMensaje` | `ConsoleColor` | `White` | Color estándar para los mensajes de texto generales. |
| `colorTextoTitulo` | `ConsoleColor` | `DarkYellow` | Color utilizado para los títulos y encabezados de secciones. |
| `colorTextoVineta` | `ConsoleColor` | `DarkRed` | Color utilizado para las viñetas de los incisos (a., b., c., etc.). |
| `colorTextoMenu` | `ConsoleColor` | `DarkCyan` | Color utilizado para las opciones del menú. |
| `colorLineasRecuadroTitulo` | `ConsoleColor` | `DarkYellow` | Color de las líneas del recuadro de títulos. |
| `colorTextoRecuadroTitulo` | `ConsoleColor` | `White` | Color del texto dentro del recuadro de títulos. |

Estas variables se acceden desde cualquier parte del sistema mediante `Globales.nombreVariable` y permiten mantener una **apariencia visual consistente** en toda la aplicación.

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
| `colorTextoValor` | `ConsoleColor` | `White` | Color del texto que escribe el usuario. |
| `checkError` | `bool` | `true` | Si es `false`, no valida longitud y devuelve el valor directamente. |

**Retorna:** Un `string` válido ingresado por el usuario.

**Comportamiento de error:**
- Muestra en rojo: *"Debe Ingresar entre X y Y caracteres"*.
- Permite reintentar limpiando la entrada anterior.

---

### 🔒 `ReadPassword(string mensaje, ConsoleColor colorTextoMensaje, ConsoleColor colorTextoValor)` → `string`

**Propósito:** Solicita al usuario una contraseña de forma segura, enmascarando cada carácter con el símbolo `·`. Soporta borrado con Backspace y una función de alternar visibilidad con `Ctrl+G`.

| Parámetro | Tipo | Valor por defecto | Descripción |
|---|---|---|---|
| `mensaje` | `string` | – | El texto del prompt que se muestra al usuario. |
| `colorTextoMensaje` | `ConsoleColor` | `White` | Color del texto del mensaje/prompt. |
| `colorTextoValor` | `ConsoleColor` | `White` | Color del texto enmascarado/visible. |

**Retorna:** Un `string` con la contraseña ingresada.

**Características:**
- Cada carácter se muestra como `·` por defecto.
- **`Ctrl+G`:** Alterna entre mostrar/ocultar la contraseña real.
- **Backspace:** Permite borrar caracteres.
- **Enter:** Confirma y retorna la contraseña.
- Solo acepta caracteres ASCII imprimibles (códigos 32 a 126).

---

### ⏸️ `EsperarTeclaFinal()`

**Propósito:** Muestra un mensaje de "Programa Finalizado" y espera a que el usuario presione una tecla para continuar. Se utiliza al final de cada ejercicio para pausar la ejecución antes de volver al menú.

**Comportamiento:**
- Posiciona el cursor 2 líneas más abajo.
- Muestra en cian: *"Programa Finalizado"* y *"Presione cualquier tecla para continuar"*.
- Oculta el cursor durante la espera.

---

### 📌 `MostrarTitulo(string titulo, ConsoleColor colorTexto, int linea, bool centrado = true)`

**Propósito:** Muestra un texto en la consola en una línea específica. Por defecto se centra horizontalmente. También actualiza el título de la ventana de la consola.

| Parámetro | Tipo | Valor por defecto | Descripción |
|---|---|---|---|
| `titulo` | `string` | – | El texto del título a mostrar. |
| `colorTexto` | `ConsoleColor` | – | El color del texto. |
| `linea` | `int` | – | La fila (posición vertical) donde se mostrará el título. |
| `centrado` | `bool` | `true` | Si es `true`, centra el texto horizontalmente. |

**Uso típico:** Encabezados de ejercicios, pie de página, y marcos decorativos.

---

### 🚧 `ProgramaEnConstruccion()`

**Propósito:** Muestra una pantalla informativa centrada indicando que el programa seleccionado aún está en construcción. Se utiliza en los ejercicios que aún no fueron realizados.

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

**Propósito:** Muestra una pantalla de despedida cuando el usuario elige salir del sistema (opción *Salir* o tecla `Esc`).

**Comportamiento:**
- Limpia la consola.
- Muestra en verde oscuro y centrado:
  - *"Sistema Finalizado."*
  - *"Gracias por su tiempo"*
  - *"Presione cualquier tecla para salir"*
- Oculta el cursor y cambia el color del texto a negro.

---

### 🖼️ `TituloRecuadro(string titulo, int filaInicial, ConsoleColor colorTexto, ConsoleColor colorLineas, int ancho, bool centrado = true)`

**Propósito:** Dibuja un recuadro decorativo con un título centrado dentro de él. Se usa para encabezados de sección destacados.

| Parámetro | Tipo | Valor por defecto | Descripción |
|---|---|---|---|
| `titulo` | `string` | – | El texto a mostrar dentro del recuadro. |
| `filaInicial` | `int` | – | Fila donde comienza a dibujarse el recuadro. |
| `colorTexto` | `ConsoleColor` | – | Color del texto del título. |
| `colorLineas` | `ConsoleColor` | – | Color de las líneas del recuadro (`+`, `-`, `\|`). |
| `ancho` | `int` | – | Ancho interior del recuadro (sin contar los bordes). |
| `centrado` | `bool` | `true` | Si es `true`, centra el recuadro horizontalmente en la consola. |

**Ejemplo visual:**
```
+--------------------------------------------------+
|                 Menu de Programas                 |
+--------------------------------------------------+
```

---

### 📋 `GenerarMenu(OpcionMenu[] listadoOpciones, int filaInicial, ...)` → `int`

**Propósito:** Genera un menú interactivo navegable con las teclas de flechas (↑/↓). El usuario puede desplazarse por las opciones, que se resaltan visualmente con un fondo gris. Al presionar `Enter` se selecciona la opción actual; con `Esc` se cierra el menú.

| Parámetro | Tipo | Valor por defecto | Descripción |
|---|---|---|---|
| `listadoOpciones` | `OpcionMenu[]` | – | Array de opciones a mostrar en el menú. |
| `filaInicial` | `int` | – | Fila donde comienza a renderizarse el menú. |
| `colorVineta` | `ConsoleColor` | `White` | Color del número/viñeta de cada opción. |
| `colorOpcionColor` | `ConsoleColor` | `White` | Color del texto secundario de cada opción (`TituloColor`). |
| `conMargenes` | `bool` | `true` | Si es `true`, dibuja líneas vacías arriba y abajo de cada opción para dar margen al resaltado. |

**Retorna:** El `Valor` de la `OpcionMenu` seleccionada, o `-1` si se presiona `Esc`.

**Características:**
- **Navegación circular:** Al llegar al final de la lista con ↓, salta a la primera opción y viceversa.
- **Resaltado visual:** La opción seleccionada se resalta con fondo `DarkGray`.
- **Esc:** Retorna `-1` para indicar que el usuario quiere salir.
- La opción *Salir* oculta su número de viñeta (color negro) para diferenciarse visualmente.
- Oculta el cursor durante la navegación.
- Muestra instrucciones: *"Presione ↑ o ↓ para navegar"* y *"Presione Esc para salir"*.

---

## 📚 Descripción de Ejercicios

### Program 00 – Hola Mundo (`Program00.cs`)

**Tema:** Introducción básica – Salida por consola.

El clásico primer programa. Muestra un mensaje de presentación personal con texto en colores, indicando nombre, la materia que cursa (**Programación III**), la carrera (**Tecnicatura Universitaria en Programación**) y la universidad (**UTN – FRT**).

**Conceptos trabajados:**
- `Console.WriteLine()` y `Console.Write()`
- Uso de `Console.ForegroundColor` para cambiar colores de texto
- `Console.ResetColor()` para restaurar el color predeterminado

---

### Program 01 – Registro y Login de Usuario (`Program01.cs`)

**Tema:** Variables de tipo `string`, entrada del usuario, comparación de valores, contraseñas enmascaradas.

Simula un sistema de registro e inicio de sesión en dos fases:

1. **Fase de registro:** solicita al usuario un nombre de usuario (4-20 caracteres), una contraseña (4-15 caracteres) y un nombre completo (4-40 caracteres).
2. **Fase de login:** presenta un formulario visual con bordes dibujados en consola donde el usuario debe ingresar sus credenciales. La contraseña se ingresa con enmascaramiento usando `ReadPassword` (muestra `·` por cada carácter) y permite alternar la visibilidad con `Ctrl+G`.
3. **Validación:** compara las credenciales ingresadas con las registradas y muestra un mensaje de bienvenida personalizado o de error.

**Conceptos trabajados:**
- Declaración y uso de variables `string`
- Comparación de cadenas con `==`
- Enmascaramiento de contraseñas con `ReadPassword`
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

#### Ejercicio 1 – Login de Usuario
Solicita usuario y contraseña (con enmascaramiento usando `ReadPassword` y soporte `Ctrl+G` para mostrar/ocultar) y usa variables `bool` para determinar:
- `usuarioEsCorrecto`: si el usuario coincide.
- `contrasenaEsCorrecta`: si la contraseña coincide.
- `accesoConcedido`: resultado del operador `&&` (AND lógico).
- Mensaje especial si el usuario es correcto pero la contraseña no.

#### Ejercicio 2 – Aprobación de Alumno
Pide 3 notas enteras y determina si el alumno aprueba (todas las notas ≥ 6) usando `&&`.

#### Ejercicio 3 – Rango Válido (Par o Impar)
Pide un número entero y determina si está dentro del rango 10-50 (exclusivo) usando `&&`.

#### Ejercicio 4 – Ingreso a Evento
Pide edad y si tiene documento. El acceso se concede solo si es mayor de 18 **Y** tiene documento (operador `&&`). Acepta múltiples formatos de respuesta (`si`, `s`, `yes`, `y`).

#### Ejercicio 5 – Puede Ver una Película
Pide edad y si está acompañado por un adulto. Puede verla si tiene 16+ **O** está acompañado (operador `||`).

**Conceptos trabajados:**
- Tipo de dato `bool`
- Operadores lógicos: `&&` (AND), `||` (OR), `!` (NOT)
- Operador ternario `? :`
- Expresiones `switch` con pattern matching y delegados `Action`
- Submenú de ejercicios con `switch` expression
- Contraseñas enmascaradas con `ReadPassword`

---

### Program 06 – Constantes (`Program06.cs`)

**Tema:** Uso de la palabra clave `const` en C# para definir valores inmutables.

Presenta una **explicación teórica completa** sobre constantes en C#: qué son, cómo se declaran, que deben inicializarse en su declaración, que son inmutables y que solo aceptan tipos simples conocidos en tiempo de compilación. Luego ofrece un **submenú con 5 ejercicios**:

#### Ejercicio 1 – Sistema de Suscripción Premium
Define constantes para nombre de servicio (`"TradyOne Premium"`), precio mensual (`$19.99`) y cantidad mínima de meses (`3`). Evalúa si un cliente cumple el mínimo de meses contratados.

#### Ejercicio 2 – Control de Compra Online
Define constantes para monto mínimo de compra (`$150.00`), nombre de tienda (`"TradyOne Store"`) y porcentaje de descuento (`10%`). Calcula si corresponde descuento y muestra el monto final a pagar. Usa `TituloRecuadro` para mostrar el nombre de la tienda.

#### Ejercicio 3 – Control de Velocidad
Define constantes para velocidad máxima (`100 km/h`), nombre de ruta (`"Ruta 9"`) y multa fija (`$500`). Evalúa si un vehículo excede el límite y muestra si corresponde multa.

#### Ejercicio 4 – Sistema de Aprobación
Define constantes para nota mínima de aprobación (`6`), nombre del curso (`"Programación III"`) y nota máxima posible (`10`). Evalúa si un alumno aprobó.

#### Ejercicio 5 – Sistema de Seguridad
Define constantes para intentos máximos (`3`), nombre del sistema y mensaje de bloqueo. Evalúa si un usuario queda bloqueado según la cantidad de intentos realizados.

**Conceptos trabajados:**
- Palabra clave `const` y su sintaxis
- Constantes de tipo `string`, `int`, `decimal` y `bool`
- Expresiones booleanas derivadas de constantes
- Operador ternario `? :` para mensajes condicionales
- Submenú de ejercicios con `switch` expression y delegados `Action`

---

### Program 07 – Constantes de Cálculo, Control y Representación (`Program07.cs`)

**Tema:** Clasificación de constantes según su propósito dentro de un sistema.

Presenta una explicación de los tres tipos de constantes según su rol en un sistema (como un módulo de facturación):

#### Constantes de Cálculo
Intervienen directamente en operaciones matemáticas:
- `const decimal TASA_IVA = 0.21m;`
- `const decimal PORCENTAJE_DESCUENTO = 0.10m;`

#### Constantes de Control
Definen el comportamiento del sistema:
- `const bool MODO_PRUEBA = false;`
- `const bool PRODUCCION = true;`
- `const int CANTIDAD_MAXIMA_INTENTOS = 3;`

#### Constantes de Representación
Definen valores simbólicos y de visualización:
- `const char SIMBOLO_PESO = '$';`
- `const string SIMBOLO_GRADOS_CELSIUS = "°C";`
- `const string SIMBOLO_GRADOS_FAHRENHEIT = "°F";`

**Conceptos trabajados:**
- Clasificación semántica de constantes (cálculo, control, representación)
- Constantes de tipo `decimal`, `bool`, `char` y `string`
- Uso de constantes `char` vs. `string`
- Título recuadrado con `TituloRecuadro`

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

## 🎮 Menú Principal

El menú principal utiliza un sistema de **navegación interactiva con flechas** (clase `OpcionMenu` + función `GenerarMenu`):

- **↑ / ↓:** Navegar entre las opciones (navegación circular).
- **Enter:** Ejecutar el ejercicio seleccionado.
- **Esc:** Salir del sistema.

La opción actualmente seleccionada se resalta con un **fondo gris** para una mejor experiencia visual. Cada opción del menú muestra su número, un título descriptivo y el nombre del ejercicio en color cian.

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
2. Abrí una terminal en la carpeta del proyecto (preferentemente maximizada para que el layout se muestre correctamente).
3. Ejecutá:

```bash
dotnet run
```

4. Se mostrará el **Menú de Programas**. Usá las flechas **↑/↓** para navegar y **Enter** para seleccionar.
5. Para salir, presioná **Esc** o seleccioná la opción *Salir*.

---

## 📄 Licencia

Proyecto académico – Uso educativo.

# Patrón Chain of Responsibility en C#

## 📌 Descripción
Este proyecto implementa el patrón de diseño **Chain of Responsibility**, que permite pasar una solicitud a través de una cadena de objetos hasta que uno de ellos la maneje.

Este patrón es útil cuando se desea desacoplar el emisor de la solicitud de sus posibles receptores, y se quiere permitir múltiples manejadores opcionales que se asignan de manera dinámica.

Este ejemplo forma parte de una serie de implementaciones prácticas de patrones de diseño en C#.

## 🛠️ Tecnologías utilizadas
- C#
- .NET (Consola)
- Visual Studio

## ▶️ Cómo ejecutar
1. Cloná este repositorio o descargalo como ZIP.
2. Abrí el proyecto en Visual Studio.
3. Ejecutá el archivo `Program.cs`.
4. Observá la salida de la consola.

## 📤 Ejemplo de salida esperada
```plaintext
El monto que se desea aprobar es de: 20000
Ejecutando la aprovacion -> Mecanico
Se delega la responsabilidad
Ejecutando la aprovacion -> Jefe Mecánico
Se delega la responsabilidad
Ejecutando la aprovacion -> Dueño del taller
Aprobado por Dueño del taller
El presupuesto quedo en estado: Aprobado

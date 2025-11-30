# Manual de Usuario – Sistema de Gestión Gastronómica

## 1. Introducción

Este manual explica cómo utilizar el sistema de gestión gastronómica "GESCOM" de manera simple y clara.

## 2. Inicio de Sesión

1. Ingrese su **Nombre de Usuario**.
2. Ingrese su **Contraseña**.
3. Presione **Iniciar Sesión**.

## 3. Menú Principal

Desde el menú principal puede acceder a:

* Gestión de Mesas
* Gestión de Usuarios
* Gestión de Comandas
* Informes
* Movimientos de Caja

## 4. Gestión de Mesas

### Crear o modificar mesas

1. Abrir la sección *Mesas*.
2. Seleccionar **Nueva Mesa** o elegir una mesa para editar.
3. Ingresar:

   * Número de mesa
   * Capacidad
   * Ubicación
   * Estado
4. Guardar los cambios.

### Estados posibles

* **Disponible**
* **Reservada**
* **No disponible**

## 5. Gestión de Comandas

### Crear una nueva comanda

1. Seleccionar una mesa disponible.
2. Indicar cantidad de comensales.
3. Agregar productos a la lista.
4. Confirmar la comanda.

Esto automáticamente:

* Cambia el estado de la mesa a *No disponible*.
* Genera un movimiento de ingreso en caja.

### Editar comanda

* Solo puede editarse si **NO** está en estado *Cancelada* o *Entregada*.
* Si intenta cambiar a un estado final, el sistema pedirá confirmación.

### Cancelar comanda

* Se registra un movimiento de **Egreso** en la caja.

## 6. Movimientos de Caja

Puede consultar:

* Fecha del movimiento
* Tipo (Ingreso/Egreso)
* Monto
* Usuario responsable
* Descripción

## 7. Reportes

### Exportar datos a Excel

1. Ingresar a la sección de gestión.
2. Elegir el reporte deseado:

   * Mozos y cantidad de comandas
   * Listas visibles en DataGridView
3. Presionar **Exportar a Excel**.
4. Seleccionar ubicación del archivo.

## 8. Consejos de Uso

* Revise bien antes de cerrar o cancelar comandas.
* Mantenga la base de datos respaldada.
* No cierre el sistema mientras se exporta a Excel.

## 9. Cierre de Sesión

En el menú principal, use **Cerrar Sesión** para volver a la pantalla de inicio.


# Manual Técnico del Sistema de Gestión Gastronómica

## 1. Introducción

Este documento describe la arquitectura, componentes internos, tecnologías utilizadas y funcionamiento técnico del sistema de gestión gastronómica desarrollado en C# con Windows Forms. 
También explica la estructura por capas, modelos de datos, flujo de información, dependencias y funcionalidades internas.

---

## 2. Arquitectura del Sistema

El sistema está construido bajo una **arquitectura en capas (N-Layers)**, organizada de la siguiente manera:

### **2.1. Capa de Presentación (capaPresentacion)**

* Formularios Windows Forms.
* Controles visuales: DataGridView, ComboBox, TextBox, RadioButton, etc.
* Manejo de eventos y validaciones de datos básicos.
* Comunicación directa con la capa de negocio.

### **2.2. Capa de Negocio (capaNegocio)**

* Implementa la lógica de negocio.
* Gestiona validaciones de entidades.
* Controla integridad de datos antes de llamar a la capa de datos.
* Intermediario entre UI y la base de datos.

### **2.3. Capa de Datos (capaDatos)**

* Acceso directo a la base de datos mediante Entity Framework.
* CRUD de cada entidad.
* Uso del contexto `GescomDBContext`.

### **2.4. Capa de Entidad (capaEntidad)**

* Contiene las clases que representan los modelos:

  * Usuario
  * Mesa
  * Comanda
  * ComandaDetalle
  * Comida
  * Bebida
  * MovimientoCaja
  * ItemMenu
  * EstadoComanda
    
* Definición de atributos y anotaciones `[Required]`.

### **2.5. Capa EF (capaEF)**

* Contiene el DbContext y los DbSet.
* Configuración de conexión y migraciones.

---

## 3. Tecnologías Utilizadas

* **Lenguaje:** C# (.NET Framework)
* **Interfaz:** Windows Forms
* **ORM:** Entity Framework
* **Base de Datos:** SQL Server & SSMS 21
* **Exportación:** EPPlus (Excel)
* **Estilos:** GunaUI 2 & Freepik (Icons)
* **Arquitectura de Software:** N-Layers

---

## 4. Base de Datos

### **Tablas:**

* Usuario
* Mesa
* Comanda
* ComandaDetalle
* Comida
* Bebida
* EstadoComanda
* MovimientoCaja

### **Relaciones:**

* **Usuario 1–N Comandas**
* **Mesa 1–N Comandas**
* **Comanda 1–N Detalles**
* **Comida/Bebida N–N Comandas** mediante detalles
* **Comanda 1–1 MovimientoCaja**

---

## 5. Lógica de Negocio Destacada

### **5.1. Gestión de Comandas**

* Crear comanda
* Modificar comanda
* Registrar egreso si se cancela
* Registrar ingreso si se finaliza
* Bloquear edición si está finalizada/cancelada

### **5.2. Movimiento de Caja**

Cada comanda genera un movimiento:

* **Ingreso** al crear comanda
* **Egreso** al cancelar

### **5.3. Control de Mesas**

* Al crear una comanda, la mesa pasa a "No disponible".
* Al finalizarla, vuelve a "Disponible".

### **5.4. Contador de Comandas por Mozo**

* Cada vez que un mozo crea una comanda:

  * `CantComandasAtendidas++`
  * Se muestra en reportes y Excel.

### **5.5. Exportación a Excel**

* Se exporta cualquier DataGridView a una hoja de Excel.
* Se incluye nombre de columnas y datos.

---

## 6. Flujo Completo de Creación de una Comanda

1. El usuario selecciona mesa, comidas y bebidas.
2. Se crea el objeto Comanda y sus Detalles.
3. Se guarda en la base de datos.
4. Se actualiza el estado de la mesa.
5. Se calcula total.
6. Se registra movimiento de caja.
7. Se incrementa `CantComandasAtendidas` del mozo.

---

## 7. Validaciones Implementadas

* Nombre obligatorio en comida/bebida.
* Precio > 0.
* Carga mínima de detalles.
* Mesa obligatoria.
* Comanda finalizada o cancelada no puede ser editada.
* No permitir mesas duplicadas.
* Estado de mesa válido.

---

## 8. Estructura del Proyecto

```
/ capaPresentacion
   / Formularios
   / Controles

/ capaNegocio
   / comidaNegocio.cs
   / bebidaNegocio.cs
   / mesaNegocio.cs
   / comandaNegocio.cs

/ capaDatos
   / comidaDatos.cs
   / bebidaDatos.cs
   / mesaDatos.cs
   / comandaDatos.cs

/ capaEntidad
   / Comida.cs
   / Bebida.cs
   / Mesa.cs
   / Comanda.cs
   / Usuario.cs

/ capaEF
   / GescomDBContext.cs
```

---

## 9. Consideraciones de Rendimiento

* Uso de `using` para liberar contexto EF.
* Uso de consultas específicas para evitar cargas innecesarias.
* Uso de `ToList()` solo cuando es necesario.

---

## 10. Conclusión

El sistema es robusto, modular y escalable gracias a su arquitectura por capas, permitiendo agregar nuevas funcionalidades sin afectar el resto de la aplicación.
La documentación técnica aquí presentada permite comprender su funcionamiento interno y facilita futuras ampliaciones.
Este sistema esta compuesto por diferentes tecnicas de programacion, como el consumo de datos para los DGV. Usuario estructura el DGV mientras que en los demas tiene un autoSize(), al igual que en sus metodos
debiendo enviar todos los parametros, diferenciando de las demas entidades solo teniendo que enviar la entidad. Esto fue realizado de esta manera debido a que es un trabajo integrador en el que quiero mostrar
las diferentes formas de desarrollar una solucion similar.

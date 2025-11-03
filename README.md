<div align="center">

| <img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/nuevoicon.png" width="50"/> | <h1>** Zombie Extracción **</h1> | <img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/nuevoicon.png" width="50"/> |
|---|---|---|

</div>

> **Zombie Extracción** es un **Prototipo de supervivencia en tercera persona**, inspirado en *Resident Evil 3 Classic*.  
> Desarrollado con **Unity 2024**, **C#**, utilizando **assets gratuitos de Unity**, animaciones de **Mixamo**, modelos propios de **Blender** y un **icono creado en Krita**.

---

## 🧠 Descripción general

En **Zombie Extracción**, el jugador debe explorar una **fábrica abandonada plagada de zombies**, buscando una **tarjeta de acceso** para extraer del mapa.  
El proyecto busca **replicar la tensión y progresión del RE3 Classic**, pero con **dirección artística única**, con un **ambiente opresivo y mucha oscuridad**.

El mapa está poblado por diferentes tipos de enemigos:

- **Humanoides:** Zombie normal, Colosos, Rápidos  
- **Animales:** Pájaros, Perros  

---

## ⚙️ Detalles técnicos

| Elemento | Descripción |
|-----------|--------------|
| 🧩 **Motor** | Unity 2024 (versión LTS) |
| 💻 **Lenguaje** | C# |
| 🎮 **Tipo de proyecto** | Prototipo académico |
| 🧠 **Inspiración** | Resident Evil 3 Classic |
| 🎨 **Estética visual** | Realista / Assets variados |
| 🧱 **Plataforma** | Windows |
| 💾 **Control de versiones** | Git / GitHub |
| 👤 **Desarrollador** | Milton Castro |

---

## 🔫 Mecánicas principales

- **Exploración y supervivencia:** el jugador debe moverse sigilosamente por la fábrica evitando o enfrentando zombies.  
- **Objetivo principal:** encontrar la tarjeta de acceso para extraer del mapa.  
- **Variedad de enemigos:** cada tipo de zombie tiene comportamiento y velocidad distintos.  
- **Sistema de inventario:** recoge botiquines y objetos útiles como la tarjeta de acceso.  
- **Ambiente opresivo:** iluminación dinámica y zonas oscuras que incrementan tensión.  
- **IA enemiga:** enemigos patrullan, detectan al jugador y reaccionan de forma progresiva.  

---

## 🖼️ Capturas del proyecto

_(Imágenes de libre licencia utilizadas con fines académicos)_

<div align="center">

<table>
  <tr>
    <td><img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/Captura%20de%20pantalla%202025-11-02%20150950.png" width="380"/></td>
    <td><img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/Captura%20de%20pantalla%202025-11-02%20150857.png" width="380"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/Captura%20de%20pantalla%202025-11-02%20151052.png" width="380"/></td>
    <td><img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/Captura%20de%20pantalla%202025-11-02%20151104.png" width="380"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/Captura%20de%20pantalla%202025-11-02%20151125.png" width="380"/></td>
  </tr>
</table>

</div>

> *Exploración de la fábrica con enemigos y elementos interactivos visibles.*

---

## 🧩 Arquitectura del código

- **PlayerController.cs** → Movimiento y acciones del jugador.  
- **EnemyAI.cs** → Comportamiento y patrullaje de zombies y animales.  
- **InventorySystem.cs** → Gestión de botiquines y tarjeta de acceso.  
- **GameManager.cs** → Control de estado del juego y objetivos.  
- **UIManager.cs** → Actualización dinámica del HUD (salud, inventario, objetivo).  

---

## 🎧 Diseño e Integración Sonora

### 🎵 Visión Sonora  
El diseño sonoro se inspira directamente en la atmósfera opresiva y cinematográfica de *Resident Evil 3*.  
Se buscó transmitir **tensión, alerta y vulnerabilidad** a través de paisajes urbanos decadentes, silencios estratégicos y efectos ambientales.

El objetivo fue crear un entorno auditivo que evoque **peligro inminente** y mantenga al jugador en constante estado de ansiedad.

---

### 🎙️ Detalle de Activos

**Activos Originales**
- **Voces:** se utilizó mi propia voz para el personaje jugable y los gruñidos de los zombies, grabadas con grabadora **Zoom**.  
- **Foley:** se registraron manualmente sonidos como **puertas, pasos, respiración** e **interacciones**, buscando una sensación realista y cercana.  

**Activos Descargados**
- **SFX complementarios:** disparos y pasos sobre superficies específicas obtenidos de **bancos de audio libres**, integrados cuando no era viable grabación propia.

**Edición y Procesamiento**
- Software de captura: **Zoom Recorder**  
- Edición mínima: **normalización, recorte y control de niveles**.  
- Procesamiento para zombies:  
  - *Pitch Shifter:* reducción de tono para voz no humana.  
  - *Reverb:* simula espacios cerrados y húmedos.  
  - *EQ:* filtrado de agudos para tono apagado y pesado.  

🎯 **Objetivo del procesamiento:** provocar incomodidad, reforzar la tensión ambiental y asegurar coherencia entre lo sonoro y lo visual.

---

### 🔊 Integración Técnica

Los sonidos fueron implementados en **Unity** mediante el sistema **AudioSource** y **scripts personalizados en C#**.

| Evento | Activación sonora |
|---------|-------------------|
| **Pasos** | Se reproducen según la velocidad del jugador. |
| **Respiración** | Activa en estado *idle* o *alerta*. |
| **Zombies** | Emite gruñidos al detectar al jugador (raycasts). |
| **Ambiente** | Loops ambientales reproducidos en zonas delimitadas. |

**Desafíos:**  
Sincronizar sonidos de pasos y disparos sin solapamiento perceptual.  
Actualmente se realizan pruebas para balancear mezcla y prioridades de audio.

---

### ⚙️ Optimización

- **Formato:** `.mp3` (compresión ligera con buena calidad).  
- **Control de peso:** archivos de corta duración para minimizar carga en ejecución.  
- **No compresión adicional dentro de Unity**, evitando pérdida extra de calidad.  
- **Reutilización parcial:** cada zombie usa clips distintos para generar variedad auditiva.

---

### 🧪 Playtesting Sonoro

Durante las pruebas se detectaron pequeños solapamientos entre **disparos y pasos**.  
Se trabaja en ajustar la **prioridad y mezcla** de clips, buscando claridad e inmersión total.  

✔️ Lo que funcionó bien:  
- Integración general estable y coherente.  
- Efectiva atmósfera de tensión.  

💡 A mejorar:  
- Equilibrio entre disparos y pasos.  

📚 Aprendizaje:  
Planificar la lógica de audio desde el código es clave para mantener escalabilidad y evitar conflictos en tiempo real.

---

### 🤖 Reflexión sobre Tendencias

- **IA sonora:** Los enemigos cuentan con dos estados auditivos — *idle* (respiración leve) y *detección* (grito).  
- **Aplicación emocional:** los cambios de estado buscan generar sobresalto y mantener la tensión narrativa.  
- **Enfoque futuro:** priorizar la integración técnica del audio antes que el diseño procedural o espacial.

---

## 🎯 Propósito académico

El desarrollo de **Zombie Extracción** tuvo como objetivo:

- Implementar **IA básica y avanzada** para distintos tipos de enemigos.  
- Desarrollar **exploración y progresión de objetivos** en un mapa cerrado.  
- Aplicar **iluminación y efectos de ambiente** para generar tensión.  
- Explorar **integración de audio original y técnico dentro del motor**.  

---

## 📜 Licencia

Proyecto de uso **académico y sin fines comerciales**.  
Todos los recursos utilizados son **de libre licencia o de autoría propia**.

---

## ✨ Cierre

> *“Sobrevivir no solo depende de tus reflejos, sino de tu capacidad de adaptarte al entorno — también a cómo suena el miedo.”*  
> — Milton Castro

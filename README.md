<div align="center">

| <img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/nuevoicon.png" width="50"/> | <h1>🧟‍♂️ Zombie Extracción 🧟‍♂️</h1> | <img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/nuevoicon.png" width="50"/> |
|---|---|---|

</div>

> **Zombie Extracción** es un **prototipo de supervivencia en tercera persona**, inspirado en *Resident Evil 3 Classic*.  
> Desarrollado con **Unity 2024**, **C#**, utilizando **assets gratuitos de Unity**, animaciones de **Mixamo**, modelos propios de **Blender**, un **icono creado en Krita**, y **diseño sonoro original** grabado y editado por **Milton Castro**.

---

## 🧠 Descripción general

En **Zombie Extracción**, el jugador debe explorar una **fábrica abandonada plagada de zombies**, buscando una **tarjeta de acceso** para escapar del lugar.  
El proyecto busca **replicar la tensión y progresión del RE3 Classic**, pero con una **dirección artística y sonora única**, ambientada en un entorno **oscuro y opresivo**.

---

## 🎧 Visión sonora

El diseño sonoro toma como principal referencia la atmósfera cinematográfica y opresiva de *Resident Evil 3*.  
Se trabajó con una mezcla de **paisajes sonoros urbanos decadentes**, **efectos aleatorios** y **silencios estratégicos**, buscando generar **tensión y vulnerabilidad constante**.

**Enfoque principal:**  
Crear un entorno auditivo que evoque peligro y descomposición, utilizando sonidos de la vida cotidiana reinterpretados como parte del mundo postapocalíptico.

---

## 🎙️ Detalle de activos sonoros

| Tipo | Descripción |
|------|--------------|
| **Voces originales** | Grabadas por **Milton Castro**, tanto para el personaje jugable como para los gruñidos de zombies. Capturadas con **grabadora Zoom**, manteniendo naturalidad con ajustes mínimos. |
| **Foley original** | Sonidos de puertas, pasos, respiración y alertas grabados manualmente en interiores para lograr resonancia real. |
| **SFX externos** | Disparos y pasos específicos descargados de bancos libres para complementar el diseño sonoro. |
| **Edición y mezcla** | Efectos procesados en software con **pitch shifting**, **reverb** y **EQ**, simulando espacios cerrados o húmedos. |

🎛️ *Ejemplo de cadena de efectos aplicada (voz de zombie):*  
Pitch Shifter → Reverb → EQ  
> Resultado: una voz distorsionada, con eco y tono bajo que transmite incomodidad y amenaza.

---

## 🔊 Integración sonora en Unity

Los sonidos fueron integrados directamente mediante **AudioSource** y **scripts en C#**.  
Se utilizaron **eventos y triggers** para activar los audios según el contexto:

- **Pasos:** sincronizados con la velocidad del jugador.  
- **Respiración:** activada en estado Idle o de alerta.  
- **Zombies:** sonidos de detección mediante raycasts.  
- **Ambiente:** loops urbanos aplicados en zonas del mapa.  

🎯 *Desafío:* sincronizar la lógica de audio con las animaciones y acciones del jugador sin generar solapamientos.

---

## 🧩 Optimización de audio

- **Formato utilizado:** `.mp3` (buena calidad y compresión eficiente).  
- **Control de peso:** archivos cortos y ligeros para minimizar el consumo de memoria.  
- **Reutilización:** se evitó la repetición de clips para dar variedad a cada zombie.  

---

## 🧪 Playtesting y evaluación

Durante las pruebas se detectaron pequeños problemas de mezcla, especialmente entre los sonidos de **disparo** y **pasos**.  
Actualmente se está evaluando si el origen es **código o mezcla sonora**, con el fin de mejorar la claridad y priorización del audio.

---

## 🧱 Detalles técnicos generales

| Elemento | Descripción |
|-----------|-------------|
| 🧩 **Motor** | Unity 2024 (LTS) |
| 💻 **Lenguaje** | C# |
| 🎮 **Tipo de proyecto** | Prototipo académico |
| 🧠 **Inspiración** | Resident Evil 3 Classic |
| 🎨 **Estética visual** | Realista / Assets variados |
| 🧱 **Plataforma** | Windows |
| 💾 **Control de versiones** | Git / GitHub |
| 👤 **Desarrollador** | Milton Castro |

---

## 🔫 Mecánicas principales

- Exploración y supervivencia en una fábrica infectada.  
- Recolección de ítems y gestión del inventario.  
- Variedad de enemigos con IA y comportamiento propio.  
- Iluminación dinámica que refuerza la tensión.  
- Integración sonora contextual en cada evento del juego.

---

## 🖼️ Capturas del proyecto

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

> *Exploración de la fábrica y activadores sonoros en acción.*

---

## 🧠 Autoevaluación

- ✅ **Fortalezas:** diseño sonoro coherente y atmósfera lograda.  
- ⚙️ **A mejorar:** mezcla entre pasos y disparos.  
- 💡 **Aprendizaje:** importancia de planificar la estructura del audio en código para mantener claridad y consistencia.

---

## 🚀 Reflexión sobre tendencias

- **IA en audio:** en el juego, los zombies usan IA sonora con estados Idle (respiración) y Detección (grito de alerta).  
- **Futuro:** el foco continuará en programación e implementación técnica del sonido, más que en generación procedural o espacial.

---

## 📜 Licencia

Proyecto de uso **académico y sin fines comerciales**.  
Todos los recursos son **de libre licencia o creados por el desarrollador**.

---

## ✨ Cierre

> *“Sobrevivir no solo depende de tus reflejos, sino de tu oído y tu capacidad de anticipar el peligro.”*  
> — **Milton Castro**

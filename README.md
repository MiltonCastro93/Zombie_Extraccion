<div align="center">

| <img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/nuevoicon.png" width="50"/> | <h1>** Zombie Extracción **</h1> | <img src="https://github.com/MiltonCastro93/Zombie_Extraccion/blob/main/nuevoicon.png" width="50"/> |
|---|---|---|

</div>

> **Zombie Extracción** es un **Prototipo de supervivencia en tercera persona**, inspirado en *Resident Evil 3 Classic*.  
> Desarrollado con **Unity 2024**, **C#**, utilizando **assets gratuitos de Unity**, animaciones de **Mixamo**, modelos propios de **Blender** y un **icono creado en Krita**.
> Juego Publicado en <a href="https://milton93.itch.io/zombie-extraction" target="_blank"><img src="https://github.com/MiltonCastro93/hello-world/blob/main/itchio-logo-white.png" alt="krita" width="80" height="60"/></a></li>

<div align="center">

<p>
  <strong>Zombie Extracción</strong> es un <strong>Prototipo de supervivencia en tercera persona</strong>, inspirado en <em>Resident Evil 3 Classic</em>.<br>
  Desarrollado con <strong>Unity 2024</strong>, <strong>C#</strong>, utilizando <strong>assets gratuitos de Unity</strong>, animaciones de <strong>Mixamo</strong>, modelos propios de <strong>Blender</strong> y un <strong>icono creado en Krita</strong>.
</p>

<p>
  <strong>Juego publicado en:</strong>
  <a href="https://milton93.itch.io/zombie-extraction" target="_blank">
    <img src="https://github.com/MiltonCastro93/hello-world/blob/main/itchio-logo-white.png" alt="Itch.io" width="80" height="60"/>
  </a>
</p>

</div>

---

## 🧠 Descripción general

En **Zombie Extracción**, el jugador debe explorar una **fábrica abandonada plagada de zombies**, buscando una **tarjeta de acceso** para extraer del mapa.  
El proyecto busca **replicar la tensión y progresión del RE3 Classic**, pero con **dirección artística única**, con un **ambiente opresivo y mucha oscuridad**.

El mapa está poblado por diferentes tipos de enemigos:

- **Humanoides:** Zombie normal, Colosos, Rápidos  
- **Animales:** Pájaros, Perros  

---

## 🎧 Visión Sonora

El diseño sonoro del proyecto toma como principal referencia la atmósfera **opresiva y cinematográfica de Resident Evil 3**.  
Se buscó transmitir una sensación constante de **tensión, alerta y vulnerabilidad**, utilizando una mezcla de **paisajes sonoros decadentes**, efectos aleatorios y silencios estratégicos.  

El objetivo fue crear un entorno auditivo que evoque **peligro inminente**, aprovechando **voces, foley y sonidos ambientales** grabados manualmente y editados para adaptarse al contexto de supervivencia.

---

### 🎙️ Detalle de Activos

#### **Activos Originales**
- **Voces:** Grabadas con mi propia voz para el personaje jugable y los zombies (gruñidos, gemidos, alertas), usando una grabadora **Zoom**.  
- **Foley:** Sonidos manuales de puertas, pasos, respiración en estado Idle y alertas de detección. Grabados en un entorno cerrado para lograr **resonancias reales**.  

#### **Activos Descargados**
- **SFX:** Disparos y pasos sobre superficies específicas descargados desde **bancos libres**, usados para complementar escenas donde no era posible grabar sonido propio.

---

### 🛠️ Edición de Activos

- **Software:** Grabadora Zoom + edición básica en software de audio.  
- **Procesos aplicados:**  
  - **Normalización y recorte** para limpieza.  
  - **Control de niveles** para coherencia de mezcla.  
  - **Pitch shifting y reverb** en voces de zombies para lograr tonos no humanos y profundidad ambiental.

#### Cadena de efectos aplicada (voz de zombie)
- **Pitch Shifter:** bajó el tono de la voz original.  
- **Reverb:** agregó eco y sensación de espacio cerrado.  
- **EQ:** recorte de agudos para un tono apagado.  

🎯 **Objetivo del procesamiento:**
- Generar **incomodidad y tensión** en el jugador.  
- Integrar el sonido dentro del entorno visual y espacial del juego.  

---

### 🔗 Integración

Los sonidos fueron integrados directamente en **Unity** mediante **AudioSource** y scripts personalizados en **C#**.  
Se usaron **eventos y triggers** para activar sonidos:

- **Pasos:** sincronizados con movimiento del jugador.  
- **Respiración:** activada en estados de reposo o alerta.  
- **Zombies:** sonidos activados mediante raycasts al detectar al jugador.  
- **Ambiente:** loops de ruido urbano en sectores específicos del mapa.  

🎯 **Desafíos:** sincronizar correctamente los sonidos con la lógica del juego sin saturar la mezcla.

---

### ⚙️ Optimización

Para mantener el equilibrio entre calidad y rendimiento:
- **Formato de audio:** `.mp3` (compresión eficiente).  
- **Duración corta** de clips para evitar pérdida de calidad.  
- **Sin compresión adicional** dentro de Unity.  
- **Diversidad limitada de clips:** cada zombie comparte sonidos Idle y de detección, aunque se prevé expandir variaciones en futuras versiones.

---

### 🧪 Playtesting

Durante las pruebas, algunos usuarios notaron **solapamiento entre sonidos de disparo y pasos**, lo que afectaba la claridad auditiva.

- **Posible causa:** conflicto en la lógica de reproducción o mezcla dentro del motor.  
- **Próximo paso:** aislar el origen del conflicto y ajustar prioridades o canales de mezcla.

---

### 🧩 Autoevaluación

- ✅ **Funcionó bien:** la ambientación y los efectos transmiten correctamente la atmósfera de peligro.  
- ⚙️ **A mejorar:** mezcla y jerarquía sonora (disparo ↔ pasos).  
- 💡 **Aprendizaje:** la planificación previa del sistema de audio facilita depuración y mantenimiento.

---

### 🔮 Reflexión sobre tendencias

- **IA sonora:** en el proyecto, los enemigos poseen dos estados auditivos:
  - **Idle:** respiración leve y repetitiva.
  - **Detección:** grito o rugido para alertar al jugador.
- **Exploración futura:** mantener el enfoque en la **implementación técnica del audio**, más que en sonido procedural o espacial.

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
| 👤 **Desarrollador** | Milton Denis Castro |

---

## 🔫 Mecánicas principales

- **Exploración y supervivencia:** moverse sigilosamente evitando o enfrentando zombies.  
- **Objetivo principal:** encontrar la tarjeta de acceso para extraer del mapa.  
- **Variedad de enemigos:** distintos comportamientos y velocidades.  
- **Inventario básico:** recoger botiquines y objetos clave.  
- **Ambiente opresivo:** iluminación dinámica y sonido ambiental.  
- **IA enemiga:** detección, persecución y respuesta progresiva.  

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

## 🎯 Propósito académico

El desarrollo de **Zombie Extracción** tuvo como objetivo:
- Implementar **IA básica y avanzada**.  
- Desarrollar **exploración y progresión de objetivos** en un entorno cerrado.  
- Aplicar **iluminación y efectos ambientales** para generar tensión.  
- Integrar **assets externos** (Mixamo, Blender, Unity Store).  
- Diseñar y **producir sonido propio**, reforzando la narrativa inmersiva.

---

## 📜 Licencia

Este proyecto es de uso **académico y sin fines comerciales**.  
Todos los recursos utilizados son **de libre licencia** o creados por el desarrollador.

---

> 🎧 *Proyecto académico desarrollado en 2024 para la UTN Buenos Aires.*  
> Diseño, sonido e implementación por **Milton Denis Castro**.

---

> *“Sobrevivir no solo depende de tus reflejos, sino de tu capacidad de adaptarte al entorno y tomar decisiones bajo presión.”*  
> — Milton Castro

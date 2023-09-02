# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

### Sistema de consultas médicas

Como desarrolladores de software, se nos pide hacer el mantenimiento de un sistema de gestión médica, especifícamente se nos pide que hagamos mantenimiento de la funcionalidad de coordinación de consultas. Para ello debemos tener en cuenta que:
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser válidado.

Para el ejercicio se pide

#### ✍ Parte 1
**Criticar el código dado en base a patrónes y principios**
AppointmentService tenia la responsabilida de conocer la informacion del medico, del paciente, de validar y crear la cita. La solucion consiste en crear una clase Patient y Doctor, que conozcan y validen la informacion del paciente y del doctor respectivamente. AppointmentService tendrá como única responsabilidad crear la cita, conociendo el paciente, el doctor y el resto de la informacion relevante.

#### 🧐 Parte 2
**Realizar las CRC correspondientes.**
<table id="card" border="1px solid">
    <tr>
        <td align="center" colspan="2">
            <p><b>AppointmentService</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Crear cita con el médico</p>
        </td>
        <td>
            <p>Doctor</p>
            <p>Patient</p>
        </td>
    </tr>
</table>

<br>

<table id="card" border="1px solid">
    <tr>
        <td align="center" colspan="2">
            <p><b>Doctor</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer datos específicos del médico</p>
        </td>
        <td>
            <p>Doctor</p>
        </td>
    </tr>
</table>

<br>
<table id="card" border="1px solid">
    <tr>
        <td align="center" colspan="2">
            <p><b>Patient</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer datos específicos del paciente</p>
        </td>
        <td>
            <p>Patient</p>
        </td>
    </tr>
</table>

<br>
#### 👩‍💻 Parte 3
**Aplique patrónes/principios según su crítica.**

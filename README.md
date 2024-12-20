# LCH.Base.Api

## After Deployment

Go to the **Kudu Console** of your web app (https://{your-website-name}.scm.azurewebsites.net/). Click on **Debug Console** dropdown in the menu and choose **CMD**. You will see your web app directory structure listed below. Use the list interface to navigate to **site > wwwroot**. Scroll down to the bottom till you come across the **web.config** file. Click on the edit icon on the left of the file which will open the file in an editor. Add the following lines under **<system.webServer>**:
```
    <security>
        <requestFiltering>
            <requestLimits maxAllowedContentLength="4294967295"  />
        </requestFiltering>
    </security>  
```
This sets the maximum request length to 4 GB. Close the Kudu Console and restart your application from Azure Portal. Then try again.

## Entity Framework Core Commands for Migrations

    Documentación: https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx
    Agregar migración: Add-Migration MyFirstMigration
    Actualizar base de datos: Update-Database ó Update-database MyFirstMigration
    Script de migración: Script-Migration ó Script-Migration -From MyFirstMigration
    Remover migración: Remove-Migration

## Paso a paso para crear una nueva API basada en la API base

    Paso 1: Clonar el proyecto
    Paso 2: Ubicarse en la rama correspondiente
    Paso 3 (IMPORTANTE): Borrar la carpeta .git (esta oculta) para no commitiar los cambios en el repositorio original
    Paso 4: Renombrar las carpetas LCH.Base.Api y LCH.Base.Api\LCH.Base.Api a un nombre a elección ej: LCH.NombreProyecto.Api
    Paso 5: Renombrar todos las ocurrencias de LCH.Base.Api (en todo el proyecto) al nombre de tu elección ej: LCH.NombreProyecto.Api (sugerencia: usar Visual Code)
    Paso 6: Borrar todas las migraciones existentes
    Paso 7: Crear las clases correspondientes de tu modelo
    Paso 8: Configurar la cadena de conexón a tu base de datos en el archivo appsettings.json
    Paso 9: Abrir la consola de Windows PowerShell
    Paso 10: Agregar la primera migración: Add-Migration Initial
    Paso 11: Obtener el Script SQL de la migración: Script-Migration
    Paso 12: Acatualizar la base de datos: Update-Database

## Script SQL Server para obtener los atributos correspondientes a un determinado modelo desde una tabla de una base de datos existente

Configuración SQL Server Management Studio para mantener saltos de línea al copiar resultados:
https://stackoverflow.com/questions/31057/how-to-insert-a-line-break-in-a-sql-server-varchar-nvarchar-string

``` sql
    SELECT
        TABLE_CATALOG
        ,TABLE_SCHEMA
        ,TABLE_NAME
    FROM INFORMATION_SCHEMA.TABLES t
    WHERE TABLE_NAME LIKE '%Sistemas%';

    SELECT
        TABLE_CATALOG
        ,TABLE_SCHEMA
        ,TABLE_NAME
        ,COLUMN_NAME
        ,DATA_TYPE
        ,IS_NULLABLE
        ,CHARACTER_MAXIMUM_LENGTH
        ,NUMERIC_PRECISION
        ,NUMERIC_SCALE
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME='Sistemas'
    ORDER BY IS_NULLABLE, DATA_TYPE;

    SELECT
        CAST(IIF(DATA_TYPE = 'varchar' AND IS_NULLABLE = 'NO', '[Required]' + CHAR(13) + CHAR(10), '') AS VARCHAR) +
        CAST(IIF(DATA_TYPE = 'varchar', '[StringLength(' + CAST(CHARACTER_MAXIMUM_LENGTH AS VARCHAR) + ')]' + CHAR(13) + CHAR(10), '') AS VARCHAR) +
        'public ' +
        CAST((CASE
                WHEN DATA_TYPE = 'bit' AND IS_NULLABLE = 'NO' THEN 'bool'
                WHEN DATA_TYPE = 'bit' AND IS_NULLABLE = 'YES' THEN 'bool?'
                WHEN DATA_TYPE = 'decimal' AND IS_NULLABLE = 'NO' THEN 'decimal'
                WHEN DATA_TYPE = 'decimal' AND IS_NULLABLE = 'YES' THEN 'decimal?'
                WHEN DATA_TYPE = 'float' AND IS_NULLABLE = 'NO' THEN 'double'
                WHEN DATA_TYPE = 'float' AND IS_NULLABLE = 'YES' THEN 'double?'
                WHEN DATA_TYPE = 'geometry' AND IS_NULLABLE = 'NO' THEN 'Geometry'
                WHEN DATA_TYPE = 'geometry' AND IS_NULLABLE = 'YES' THEN 'Geometry?'
                WHEN DATA_TYPE = 'int' AND IS_NULLABLE = 'NO' THEN 'int'
                WHEN DATA_TYPE = 'int' AND IS_NULLABLE = 'YES' THEN 'int?'
                WHEN DATA_TYPE = 'varchar' AND IS_NULLABLE = 'NO' THEN 'string'
                WHEN DATA_TYPE = 'varchar' AND IS_NULLABLE = 'YES' THEN 'string?'
                WHEN DATA_TYPE = 'varbinary' AND IS_NULLABLE = 'NO' THEN 'byte[]'
                WHEN DATA_TYPE = 'varbinary' AND IS_NULLABLE = 'YES' THEN 'byte[]?'
                WHEN (DATA_TYPE = 'date' OR DATA_TYPE = 'datetime') AND IS_NULLABLE = 'NO' THEN 'DateTime'
                WHEN (DATA_TYPE = 'date' OR DATA_TYPE = 'datetime') AND IS_NULLABLE = 'YES' THEN 'DateTime?'
                WHEN DATA_TYPE = 'datetimeoffset' AND IS_NULLABLE = 'NO' THEN 'DateTimeOffset'
                WHEN DATA_TYPE = 'datetimeoffset' AND IS_NULLABLE = 'YES' THEN 'DateTimeOffset?'
                ELSE ''
            END) AS VARCHAR) +
        ' ' + COLUMN_NAME + ' { get; set; }' +
        CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10)
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME='Sistemas'
    ORDER BY IS_NULLABLE, DATA_TYPE;
```

## Para bases de datos Postgre

Requerimientos para implementar datos espaciales (spatial data) - Instalar complemento PostGIS (<http://postgis.net/install/>) para PostgreSQL (según la versión utilizada) desde aquí <http://download.osgeo.org/postgis/windows/>

Script para cerrar todas las conexiones y poder borrar la base de datos
SELECT pg_terminate_backend(pg_stat_activity.pid)
FROM pg_stat_activity
WHERE pg_stat_activity.datname = 'BaseDB';

## Pasos para obtener un token de autorización (BASIC)

    Paso 1: Abrir Postman
    Paso 2: Ir a la pestaña Authorization
    Paso 3: En TYPE seleccionar OAuth 2.0
    Paso 4: Click en "Get New Access Token"
    Paso 5: Completar los siguientes datos
        Token Name: Token Base Client (Es un nombre arbitrario)
        Grant Type: Password Credentials
        Username: ealvarez (Nombre de usuario) si Grant Type es Password Credentials
        Password: 123456 (Contraseña) si Grant Type es Password Credentials
        Access Token URL: https://localhost:5001/connect/token
        Client ID: base.client (Depende del Client configurado en el servidor de Identity Server)
        Client Secret: 2BD1930D-0B21-4708-BA3C-E2583A41A2DA (Depende del Secret configurado en el servidor de Identity Server)
        Scope: base.api (Depende del ApiResource configurado en el servidor de Identity Server)
        Client Authentication: Send as Basic Auth header
    Paso 6: Presionar el botón "Get New Access Token"

    Paso 7 (IMPORTANTE): LA SOLICITUD ANTERIOR FALLARÁ PORQUE SE ESPERA EL PARÁMETRO "CodSistema" Y EL FORMULARIO NO PERMITE ENVIARLO.
        PERO LO QUE NOS INTERESA ES EL HEADER "Authorization" QUE GENERA LA SOLICITUD. PARA OBTENER NOS DIRIJIMOS A LA CONSOLA DE POSTMAN
        Y BUSCAMOS EL RESULTADO DE LA SOLICITUD QUE DEBERÍA HABER FALLADO CON CÓDIGO "400" Y ERROR "Error: invalid_username_or_password".
        EXPANDIMOS LA SOLICITUD PARA VER EL DETALLE DE LA MISMA Y BUSCAMOS EN LA SECCIÓN "Request Headers" EL HEADER "Authorization" QUE
        DEBERÍA SER SIMILAR A "Basic aGVycmFtaWVudGFzLmNsaWVudDpIZXJyYW1pZW50YXNDbGllbnQtZTk0MWUwMzQtZjU3Ny00MzQ0LWE2NTktNGZhNTg0YThiMmIy".
        COPIAMOS EL "Basic" Y LO UTILIZAMOS EN LAS SOLICITUDES DE LOGIN TANTO DE POSTMAN COMO DESDE EL FRONT (ANGULAR).

## Pasos para generar un certificado X.509 para IdentityServer4

    Paso 1: Descargar OpenSSL desde aquí https://slproweb.com/products/Win32OpenSSL.html
    Paso 2: Instalar OpenSSL seleccionando instalar las DDLs en el directorio de instalación (/bin)
    Paso 3: Ir a la carpeta OpenSSL-Win64\bin, abrir openssl.exe como administrador y ejecutar el siguiente comando:
        req -x509 -newkey rsa:2048 -sha256 -nodes -keyout DbPostgreSqlIdentity.key -out DbPostgreSqlIdentity.crt -subj "/CN=db.postgresql.identity.com.ar" -days 365
    Paso 4: Ejecutar el siguiente comando y establecer Export Password:
        pkcs12 -export -out DbPostgreSqlIdentity.pfx -inkey DbPostgreSqlIdentity.key -in DbPostgreSqlIdentity.crt -certfile DbPostgreSqlIdentity.crt
    Paso 5: Copiar el archivo DbPostgreSqlIdentity.pfx a la raíz del proyecto y configurar las variables CertificateThumbprint y CertificateExportPassword en el archivo appsettings.json
    Paso 6: El CertificateThumbprint se obtiene en el paso 7 en el proceso de instalación del certificado el el Host Productivo
    Paso 7: Una vez generado el certificado es necesario instalarlo ya sea en el Host productivo o Azure. Leer la siguiente documentación:
        https://teilin.net/self-signed-certificate-and-configuring-identityserver-4-with-certificate/
        Nota: Ruta donde se guarda la configuración de consola en windows por defecto: C:\Users\Juanjo\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Administrative Tools

Url para ver detalle del servidor IdentityServer4
<https://localhost:5001/.well-known/openid-configuration>

-- TAB_NACIONALIDADES
INSERT INTO TAB_NACIONALIDADES (NOMBRENACIONALIDAD)
VALUES ('Ecuador');

-- TAB_DEPORTES
INSERT INTO TAB_DEPORTES (NOMBREDEPORTE)
VALUES ('Fútbol'),
       ('Atletismo'),
       ('Natación');

-- TAB_CIUDADES
INSERT INTO TAB_CIUDADES (NOMBRECIUDAD, PAIS)
VALUES ('Quito', 'Ecuador'),
       ('Guayaquil', 'Ecuador'),
       ('Cuenca', 'Ecuador');

-- TAB_DEPORTISTAS
INSERT INTO TAB_DEPORTISTAS (IDNACIONALIDAD, NOMBREDEPORTISTA, FECHANACIMIENTO, TELEFONO)
VALUES (1, 'Carlos Pérez', '1990-05-15', '0991234567'),
       (1, 'María González', '1995-09-30', '0987654321'),
       (1, 'Luis Romero', '1988-11-20', '0971111111');

-- TAB_EVENTOS
INSERT INTO TAB_EVENTOS (IDDEPORTE, IDSEDE, NOMBREEVENTO, FECHAEVENTO)
VALUES (1, 2, 'Final de Fútbol', '2023-08-15'),
       (2, 1, 'Carrera de 100 metros', '2023-08-16'),
       (3, 3, 'Competencia de Natación', '2023-08-17');

-- TAB_RESULTADOS
INSERT INTO TAB_RESULTADOS (IDEVENTO, IDDEPORTISTA, POSICION, MARCATIEMPO, RONDA)
VALUES (1, 1, 1, '00:30:00', 'Final'),
       (1, 2, 2, '00:30:15', 'Final'),
       (1, 3, 3, '00:30:30', 'Final');

-- TAB_SEDESOLIMPICAS
INSERT INTO TAB_SEDESOLIMPICAS (IDCIUDAD, NOMBRESEDE, ANIOCELEBRACION)
VALUES (1, 'Estadio Olímpico', 2023),
       (2, 'Piscina Olímpica', 2023),
       (3, 'Polideportivo Olímpico', 2023);

-- TAB_USUARIOS
INSERT INTO TAB_USUARIOS (NOMBREUSUARIO, USUARIO, CLAVE, ROL)
VALUES 
       ('Usuario1', 'admin', 'admin', 'Usuario'),
       ('Usuario2', 'user2', 'user456', 'Usuario');

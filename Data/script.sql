INSERT INTO
    Productos
VALUES
    (
        1,
        'Mani',
        1500,
        250.0,
        375000.0,
        300.0,
        20.0,
        '2022-03-13 22:16:59.278521',
        50.0
    );

INSERT INTO
    Productos
VALUES
    (
        2,
        'Pasas',
        2500,
        100.0,
        250000.0,
        150.0,
        50.0,
        '2022-03-13 22:17:30.599145',
        100.0
    );

INSERT INTO
    Productos
VALUES
    (
        3,
        'Mani con pasas',
        0,
        350.0,
        NULL,
        450.0,
        28.571426391601564276,
        NULL,
        0.0
    );

INSERT INTO
    ProductoDetalles
VALUES
    (1, 'Caja', 500.0, 150000.0, 25000.0, 1);

INSERT INTO
    ProductoDetalles
VALUES
    (2, 'Caja', 500.0, 75000.0, 50000.0, 2);

INSERT INTO
    ProductoDetalles
VALUES
    (3, 'Fundita', 0.0, NULL, 0.0, 3);

INSERT INTO
    PDPUtilizados
VALUES
    (1, 2, 1, 1);

INSERT INTO
    PDPUtilizados
VALUES
    (2, 2, 2, 1);

INSERT INTO
    PDPUtilizados
VALUES
    (3, 2, 1, 2);

INSERT INTO
    PDPUtilizados
VALUES
    (4, 3, 1, 3);

INSERT INTO
    PDPUtilizados
VALUES
    (5, 1, 1, 5);

INSERT INTO
    PDPUtilizados
VALUES
    (6, 3, 2, 5);

INSERT INTO
    PDPUtilizados
VALUES
    (7, 2, 1, 11);

INSERT INTO
    PDPUtilizados
VALUES
    (8, 2, 2, 11);

INSERT INTO
    ProductosEmpacados
VALUES
    (
        11,
        'Mani con pasas empacado',
        '2022-03-13 23:45:09.52474',
        3
    );
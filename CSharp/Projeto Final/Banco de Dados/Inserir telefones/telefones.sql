update cliente
set telefone = (CONCAT('(21) ', cast(CEILING(9999*RAND()) as char), '-' , 
cast(CEILING(9999*RAND()) as char)))
where idCliente in ( select idCliente from cliente where telefone = '(  )      -');


update cliente
set Celular = (CONCAT('(21) ', cast(CEILING(99999*RAND()) as char), '-' , 
cast(CEILING(9999*RAND()) as char)))
where idCliente in ( select idCliente from cliente where celular = '(  )      -')

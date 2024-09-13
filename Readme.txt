
En Capa CleanArquitecture.Application:
Se crea 3 carpetas:
Behavious, Contracts y Features.
Behavious: Comportamiento en español. Se aplicará durante la implementación del caso de uso. Validación de datos, Logs de transacciones, etc...
Contracts: Debe incluir las interfaces que representen la abstracción de los casos de uso. Son interfaces.
Features: Aplicará el patron CQRS para manejar los casos de uso.
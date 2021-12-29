# DirectoryBackend
For Karpunkin Maxim

#### Получить инфу по директории, где DIR это директория
https://localhost:44364/info?directory=*DIR*
> (Возвращает все директории и файлы из указанной директории)
#### Получить текст по файла, где DIR это директория, а FILE_NAME название файла с его расширением
https://localhost:44364/info?filePath=*DIR*\*FILE_NAME*
> (Возвращает текст из файла)
#### Для проверки работоспособности API, есть healthCheck
https://localhost:44364/directory

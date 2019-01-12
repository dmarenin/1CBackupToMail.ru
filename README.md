# 1CBackupToMail.ru
sample mail web dav client

this is clone repo from https://github.com/erastmorgan/Mail.Ru-.net-cloud-client

https://infostart.ru/public/828998/

for start:

path_to_exe "path_unload_file" "path_cloud_folder" "login "password"

sample:

create bak

"C:\Program Files\7-Zip\7z.exe" a "E:\R_BASE\komi\%date:~6,4%_%date:~3,2%_%date:~0,2%.7z" "E:\komi_retail" -ssw -mf=BCJ2 -mx
"E:\copy to cloud\ConsoleApplication1.exe" "E:\R_BASE\komi\%date:~6,4%_%date:~3,2%_%date:~0,2%.7z" "/komi/"

upload

"E:\copy to cloud\ConsoleApplication1.exe" "E:\R_BASE\gs\%date:~6,4%_%date:~3,2%_%date:~0,2%.7z" "/gs/" "dev@mail.ru" "22215"


# pink-dream

Github yükleme adimlari: 

Dosyanın bulunduğu konumda git bash açıyoruz. /n
git add .
git commit -m "Kaydedilmemiş değişiklikler" 
//git yorumu istenilen şekilde değiştirilir.

git geçmişini temizlemek için: /n
git filter-branch --force --index-filter \
'git rm --cached --ignore-unmatch Library/PackageCache/com.unity.burst@1.8.4/.Runtime/libburst-llvm-14.dylib' \
--prune-empty --tag-name-filter cat -- --all

güncellenmiş geçmişi uzak depoya itmek için:/n
git push origin --force --all

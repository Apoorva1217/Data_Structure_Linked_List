read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Ability to search LinkedList to find Node with value 30"
git push origin $a
git checkout master
git merge $a
git push origin master --force

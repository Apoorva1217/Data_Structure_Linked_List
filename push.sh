read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Ability to insert 40 after 30 to the Linked List sequence of 56->30->70"
git push origin $a
git checkout master
git merge $a
git push origin master --force

read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Ability to delete 40 from the Linked List sequence of 56->30->40->70 and show the size of LinkedList is 3"
git push origin $a
git checkout master
git merge $a
git push origin master --force

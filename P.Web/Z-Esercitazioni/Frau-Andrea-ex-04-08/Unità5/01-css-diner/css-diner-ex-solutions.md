

# 1. Select the plates
plate

# 2. Select the bento boxes
bento

# 3. Select the fancy plate
#fancy

# 4. Select the apple on the plate 
plate apple

# 5. Select the pickle on the fancy plate 
#fancy pickle

# 6. Select the small apples 
apple.small

# 7. Select the small oranges
orange.small

# 8. Select the small oranges in the bentos
bento orange.small

# 9. Select all the plates and bentos  
plate, bento 

# 10. Select all the things!
*

# 11. Select everything on a plate
plate *

# 12. Select every apple that's next to a plate
plate + apple

# 13. Select the pickles beside the bento
bento ~ pickle

# 14. Select the apple directly on a plate
plate > apple

# 15. Select the top orange
plate > orange:first-child

# 16. Select the apple and the pickle on the plates
plate >:only-child

# 17. Select the small apple and the pickle
pickle,apple:last-child

# 18. Select the 3rd plate 
plate:nth-child(3)

# 19. Select the 1st bento 
bento:nth-last-child(3)

# 20. Select first apple 
apple:first-of-type

# 21. Select all even plates 
plate:nth-of-type(even)

# 22. Select every 2nd plate, starting from the 3rd 
plate:nth-of-type(2n+3)

# 23. Select the apple on the middle plate 
plate apple:only-of-type

# 24. Select the last apple and orange 
orange:last-of-type,apple:last-of-type

# 25. Select the empty bentos 
bento:empty

# 26. Select the big apples 
apple:not(.small)

# 27. Select the items for someone 
*[for]

# 28. Select the plates for someone 
plate[for]

# 29. Select Vitaly's meal 
bento[for="Vitaly"]

# 30. Select the items for names that start with 'Sa' 
plate,bento[for^="Sa"]

# 31. Select the items for names that end with 'ato' 
plate,bento[for$="ato"]

# 32. Select the meals for names that contain 'obb' 
bento[for*="obb"]
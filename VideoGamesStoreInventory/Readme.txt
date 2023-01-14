Video Games Store Inventory

Store points:
- brick and mortar store with a shipping capabilities,
- sells and buys physical copies of video games to and from customers,
- possible future expansions towards more variety of products

Web app points:
- database stores all necessary information for performing sales of physical copies of video games,
- API allows the operation of Creating, Reading, Updating and Deleting data contained in the database,
- 
- the body of code allows the expansion of business in the future by adding new entities and functionalities

Expansion of business
- opening new stores,
- opening new warehouses,
- selling new variety of products

New variety of products:
- gaming systems,
- vaping accessories

New functionalities:
- front-end for store staff,
- front-end for online customers - e-commerce style with basket,
- invoicing module,
- pop-up callendar for entering sell/buy date - also front-end probably

Useful stuff to check out:
- video game database with API https://www.igdb.com/
- another video game database https://www.mobygames.com/browse/games/full,1/


Thoughts about the code:

Why use enum instead of giving a user freedom to type a game system manually with a property /* public string Category {get; set;} */
- to decrease mistyping errors,
- to make filtering by gaming console more accurate - you don't have to take into account misspelling of the system's names
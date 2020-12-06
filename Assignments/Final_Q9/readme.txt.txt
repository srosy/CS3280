I have 3 classes.

Classes: Animal, Hippo, BabyHippo
Hierarchy: Animal -> Hippo -> BabyHippo

Animal is abstract so Hippo must implement all abstract methods/properties.
Hippo isn't abstract, but contains a virtual property called NickName.
BabyHippo inherits from Hippo and has all the same properties/methods available to it.
Since NickName is virtual, I can override it to do something else than what's predefined in Hippo.
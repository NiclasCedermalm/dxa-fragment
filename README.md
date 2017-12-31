DXA Fragments Module
=========================

This is a simple module to generate standalone fragments on DXA sites. This can be handy for community portals, E-Commerce sites etc.
The fragments are basically standard Tridion pages without header & footer where one/several content components are added.
The fragments come in two different flavours:

- Clean fragments - renders as-is without anything else (no HTML body, no CSS and scripts)
- Fragments with HTML containers - renders the content in DXA HTML container which works with your current CSS. A full HTML page with CSS/JS but without the header & footer.  

Prerequisites
----------------

The module has been developed using DXA 1.7 which includes support for SDL Web 8 and SDL Web 8.5. DXA 1.8 can be used as well where the pom.xml/package.config needs to be updated to use 1.8 instead of 1.7.

Setup
-------

Setup the module in CMS by importing the provided content porter package (under cms/) into your SDL Tridion Sites CMS where DXA is installed.

Compile the DXA module (there are variants for both .NET and Java) and install it the usual way into your DXA web application (add new JAR/DLL/Area etc).

Branching model
----------------

We intend to follow Gitflow (http://nvie.com/posts/a-successful-git-branching-model/) with the following main branches:

 - master - Stable
 - develop - Unstable
 - release/x.y - Release version x.y

Please submit your pull requests on develop. In the near future we intend to push our changes to develop and master from our internal repositories, so you can follow our development process.


License
---------

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and limitations under the License.

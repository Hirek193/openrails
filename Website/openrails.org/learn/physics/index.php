<?php include "../../shared/head.php" ?>
  </head>
  <body>
    <div class="container"><!-- Centres content and sets fixed width to suit device -->
<?php include "../../shared/banners/choose_banner.php" ?>
<?php include "../../shared/banners/show_banner.php" ?>
<?php include "../../shared/menu.php" ?>
      <div class="row">
        <div class="col-md-4">
          <h1>Learn > Physics</h1>
        </div>
      </div>
      <div class="row">
        <div class="col-md-2">&nbsp;</div>
        <div class="col-md-8">
          <h2>Models in Open Rails</h2>
          <p>
            Open Rails strives to match the real world operation of trains as faithfully as possible through research and development of algorithms to provide accurate performance. 
            We see these algorithms at work in a loco's smoke which changes intensity with the throttle and also changes color with the amount of unburnt material in the
            exhaust.
          <p>
            But some of the key algorithms in Open Rails are not visible at all. 
            The ones that depend on physical properties such as weight, friction etc. are collectively known as the OR Physics. 
          </p>
          <h3>OR Physics</h3>
          <p>
          Typically these algorithms are just formulas, such as the rolling resistance of a train which is greater when at rest than it is when first moving and
          then rises again with speed. Open Rails also considers the extra resistance of a train rounding a tight curve and even passing through a tunnel!
          </p>
          <p>
            <img src="https://www.coalstonewcastle.com.au/images/physics/tunnel_drawings.png" width=617/>
          </p>
          <p>
            &nbsp;
          </p>
          <p>
            Other algorithms are interesting because they depend on past operation. An example is braking where compressed air takes time to bleed from a 
            reservoir and apply the brakes. Braking a train is very different from the instant response when braking a road vehicle.
          </p>
          <h2>Coals to Newcastle (CTN)</h2>
          <p>
            Some of these algorithms and the OR Physics are explained in the OR Operating Manual, but a detailed source can be found at 
            <a href="https://www.coalstonewcastle.com.au/physics/">Coals to Newcastle</a> (CTN). 
            This website is created and maintained by Peter Newell, a long-time contributor to the Open Rails project. 
          </p>
          <p>
            For a realistic simulation, it is vital that the loco pulling the train and the cars that make up the train exhibit the same behaviour as 
            the real rolling stock. To make sure that your models have the most realistic performance possible, CTN provides a number of tools 
            which can help the OR user and modeller to define their train physics accurately. These tools are described below.
          </p>
          <h3>Physics Overview and Prototype Information</h3>
          <p>
            CTN provides brief descriptions to give the user an understanding of how a train will behave in real life.
          </p>
          <p>
            For example, for a train to move forward the train resistance needs to be overcome by the force generated by the locomotive.
            The website <a href="https://www.coalstonewcastle.com.au/physics/resistance/">provides an overview</a> describing how resistance values are 
            calculated by various railway companies past and present. 
          </p>
          <p>
            CTN also <a href="https://www.coalstonewcastle.com.au/physics/test-resources/">publishes some test reports</a> which can be used for 
            performance testing.
          </p>
          <h3>Test Stock</h3>
          <p>
            Steam engines have complex behaviour because the power produced depends on the state of the water and steam in the boiler and the heat going into 
            the boiler depends on the state of the fuel and air flow in the firebox. 
          </p>
          <p>
            <img src="https://www.coalstonewcastle.com.au/downloads/physics/merchant_navy.gif" style="float: right; margin-left: 1em;"/>
            As well as the amount of steam, water, fuel and the heat energy in them, the OR Physics makes use of the number, bore and stroke of the cylinders to 
            calculate the pressure at each point in the piston's cycle. 
            It even calculates the maximum force that the driving wheel exerts on the rail so that, with too much throttle, the model loco slips under the same 
            conditions as the real one.
          </p>
          <p>
            Similarly a diesel locomotive can have its own complexities, and CTN offers a number of predefined model diesel locos.
          </p>
          <p>
            These <a href="https://www.coalstonewcastle.com.au/physics/stock/">test models</a> have 3 aims:
            <ul>
              <li>Demonstrate the accuracy of the OR algorithms by comparing OR performance with railway company test reports.</li>
              <li>Provide users with a working model that they can use as an example to define their own models.</li>
              <li>Provide a “known working model” when trying to identify potential bugs in models or in OR Physics.</li>
            </ul>
          </p>
          <p>
            <img src="https://www.coalstonewcastle.com.au/downloads/physics/rocket.gif" style="float: right; margin-left: 1em;" />
            This <a href="https://www.coalstonewcastle.com.au/physics/stock/">Test Stock page</a> provides users with working example from one of the oldest and 
            smallest locomotives ever - <a href="https://www.coalstonewcastle.com.au/physics/stock/#rainhill">Stephenson's Rocket</a> -
            through to some of the most powerful modern steam and diesel locomotives.
          </p>
          <h3>Test Route</h3>
          <p>
            CTN publishes two test routes for the OR modeller. These test routes are designed to:
            <ul>
              <li>Provide some common gradients for users to test the performance and operation of their locomotives in hauling loads up a gradient.</li>
              <li>Along with the models already mentioned, the test route can be used to identify any OR coding issues.</li>
            </ul>
            By having a small well-defined scenario which OR developers can use to "reproduce" a suspected fault, they can more easily 
            identify any coding errors and correct them. 
            Users reporting faults should consider using the CTN test stock and routes to clearly identify any issues that they are experiencing.
          </p>
          <p>
            Two routes are available:
            <ul>
              <li><a href="https://www.coalstonewcastle.com.au/physics/route/">Standard Route</a> – provides users with typical gradients (maximum 1 in 25 – 4%), refuelling functions, turntables, etc.</li>
              <li><a href="https://www.coalstonewcastle.com.au/physics/stock/#select">Steep Gradient</a> – provides users with steeper gradients typical of those encountered by a geared steam locomotive (maximum 1 in 7 – 14%).</li>
            </ul>
          </p>
          <h3>Suggested Physics Default Values</h3>
          <p>
            When configuring a model in OR, Peter recommends that you find specifications for the model from a reputable source. However some 
            information may not always be available, so it may be necessary to use information based upon an "educated guess" as follows.
          </p>
          <p>
            Default values can be found throughout the CTN description pages, such as 
            <a href="https://www.coalstonewcastle.com.au/physics/brakes/#braking_ratio">information on brakes</a> and how to set them up, 
            or by using some of the default calculators 
            (e.g. <a href="https://www.coalstonewcastle.com.au/physics/brakes-settings/#maxbrakeforce">maximum brake force calculator</a>).
          </p>
          <h2>Can you help with information?</h2>
          <p>
            To maintain a key resource like CTN takes a fair amount of effort, so if you have any general resource information that might be of assistance to others, 
            or can identify any errors or gaps in information, then please <a href="https://www.coalstonewcastle.com.au/contact/">contact Peter</a> and let him know.
          </p>
        </div>
        <div class="col-md-2">&nbsp;</div>
      </div>
<?php include "../../shared/tail.php" ?>
<?php include "../../shared/banners/preload_next_banner.php" ?>
  </body>
</html>
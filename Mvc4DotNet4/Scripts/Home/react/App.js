import React from 'react';

import Heading from './components/Heading';
import Welcome from './components/Welcome';
const App = () => (
  <React.Fragment>
    <Heading heading='React in My ASP.NET MVC Application!' />
    <Welcome name="grasshopper" />
  </React.Fragment>
);

export default App;
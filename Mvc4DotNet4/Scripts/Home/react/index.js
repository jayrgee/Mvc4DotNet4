import React from 'react';
import { render } from 'react-dom';

import Heading from './components/Heading';
import Welcome from './components/Welcome';
const App = () => (
  <React.Fragment>
    <Heading heading='React in My ASP.NET MVC Application!' />
    <Welcome name="grasshopper" />
  </React.Fragment>
);

render(<App />, document.getElementById('my-react-app'));
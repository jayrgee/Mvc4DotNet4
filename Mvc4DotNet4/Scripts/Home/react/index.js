import React from 'react';
import { render } from 'react-dom';

import Heading from './components/Heading';
import Welcome from './components/Welcome';
const App = () => (
  <React.Fragment>
    <Heading heading='React in ASP.NET MVC!' />
    <Welcome name="foo" />
  </React.Fragment>
);

render(<App />, document.getElementById('my-react-app'));
import React from 'react';
import { render } from 'react-dom';

const App = () => (
    <React.Fragment>
        <h1>React in ASP.NET MVC!</h1>
        <h2>Hello foo World</h2>
    </React.Fragment>
);

render(<App />, document.getElementById('my-react-app'));
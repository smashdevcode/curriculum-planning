import React from 'react';

export default class Main extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      courses: []
    };
  }

  componentDidMount = () => {
    let _this = this;

    fetch('/api/courses')
      .then(function (response) {
        return response.json();
      })
      .then(function (data) {
        _this.setState({
          courses: data
        });
      });
  };

  render() {
    return (
      <div>
        {this.state.courses.map((course) => (
          <h2 key={course.id}>{course.title}</h2>
        ))}
      </div>
    );
  }
}

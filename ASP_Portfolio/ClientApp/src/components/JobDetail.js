import React, {Component} from 'react';
import axios from 'axios';

export class JobDetail extends Component{

    constructor(props){
        super(props);

        this.onChange = this.onChangeTitle.bind(this);
        this.onChange = this.onChangeCompany.bind(this);
        this.onChange = this.onChangeProvince.bind(this);
        this.onChange = this.onChangeCity.bind(this);
        this.onChange = this.onChangeStartDate.bind(this);
        this.onChange = this.onChangeEndDate.bind(this);
        this.onChange = this.onChangeDescription.bind(this);
        this.onSubmit = this.onSubmit.bind(this);

        this.state = {
            title: '',
            company: '',
            city: '',
            province: '',
            startDate: new Date(),
            endDate: new Date(),
            description: '',
        }
    }

    componentDidMount(){
        this.populateJobData();
    }

    populateJobData(){
        const {id} = this.props.match.params;

        axios.get('api/Jobs/Detail/' + id).then(job => {
            const response = job.data;

            this.setState({
                title: response.title,
                company: response.company,
                city: response.city,
                province: response.province,
                startDate: new Date(response.startDate).toISOString().slice(0, 10),
                endDate: response.endDate ? new Date(response.endDate).toISOString().slice(0, 10) : null,
                description : response.description
            })
        })
    }

    onChangeTitle = (e) => {
        this.setState({
            title: e.target.value
        });
    }

    onChangeCompany= (e) =>{
        this.setState({
            company: e.target.value
        });
    }

    onChangeCity = (e) =>{
        this.setState({
            city: e.target.value
        });
    }

    onChangeProvince = (e) =>{
        this.setState({
            province: e.target.value
        });
    }

    onChangeDescription = (e) =>{
        this.setState({
            description: e.target.value
        });
    }

    onChangeStartDate = (e) => {
        this.setState({
            startDae: e.target.value
        });
    }

    onChangeEndDate = (e) => {
        this.setState({
            endDate: e.target.value
        });
    }

    onSubmit = (e) =>{
        e.preventDefault();
        const {history} = this.props;
        const {id} = this.props.match.params;

        let jobObject = {
            title: this.state.title,
            company: this.state.company,
            city: this.state.city,
            province: this.state.province,
            startDate: this.state.startDate,
            endDate: this.state.endDate ? this.state.endDate : null,
            description: this.state.description
        }

        axios.put('api/jobs/update/' + id, jobObject).then(result => {
            history.push('/jobs')
        })
    }

    render(){
        return <>
                <div className="trip-form">
                    <h3>Edit a Job</h3>
                    <form onSubmit={this.onSubmit}>
                        <div className="form-group">
                            <label>Job Title: </label>
                        <input type="text" className="form-control" value={this.state.title} onChange={this.onChangeTitle}></input>
                        </div>
                        <div className="form-group">
                            <label>Company: </label>
                            <input type="text" className="form-control" value={this.state.company} onChange={this.onChangeCompany}></input>
                        </div>
                        <div className="form-group">
                            <label>City: </label>
                            <input type="text" className="form-control" value={this.state.city} onChange={this.onChangeCity}></input>
                        </div>
                        <div className="form-group">
                            <label>Province: </label>
                            <input type="text" className="form-control" value={this.state.province} onChange={this.onChangeProvince}></input>
                        </div>
                        <div>
                            <label>Job Description: </label>
                            <input type="text" className="form-control" value={this.state.description} onChange={this.onChangeDescription}></input>
                        </div>
                        <div className="row">
                            <div className="col col-md-6 col-sm-6 col-xs-12">
                                <div>
                                    <label>Start Date: </label>
                                    <input type="date" className="form-control" value={this.state.startDate} onChange={this.onChangeStartDate}></input>
                                </div>
                        
                            </div>
                            <div className="col col-md-6 col-sm-6 col-xs-12">
                                <div className="form-group">
                                    <div>
                                        <label>End Date: </label>
                                        <input type="date"  className="form-control" value={this.state.endDate} onChange={this.onChangeEndDate}></input>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div className="form-group">
                            <input type="submit" value="Edit Job" className="btn btn-primary"/>
                        </div>
                    </form>
                </div>
            </>
    }
}